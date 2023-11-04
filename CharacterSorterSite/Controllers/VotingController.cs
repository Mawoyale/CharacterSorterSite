using CharacterSorterSite.Data;
using CharacterSorterSite.Models;
using CharacterSorterSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSorterSite.Controllers
{
    public class VotingController : Controller
    {
        private readonly CharacterContext _context;

        public VotingController(CharacterContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("NarutoFranchiseID", "YuukiYuunaFranchiseID", "GurrenLagannFranchiseID", "ClannadFranchiseID", "UminekoFranchiseID", "SteinsGateFranchiseID")] FranchiseIdsVM franchiseIdsVM)
        {

            await ResetCharacterDataAndDeleteMatches();


            List<int> franchiseIds = new List<int>()
            {
                franchiseIdsVM.NarutoFranchiseID,
                franchiseIdsVM.YuukiYuunaFranchiseID,
                franchiseIdsVM.GurrenLagannFranchiseID,
                franchiseIdsVM.ClannadFranchiseID,
                franchiseIdsVM.UminekoFranchiseID,
                franchiseIdsVM.SteinsGateFranchiseID,
            };

            List<Character> characters = new List<Character>();


            foreach (int franchiseId in franchiseIds)
            {
                if (franchiseId != 0)
                {
                    List<Character> currentCharacters = _context.Characters.Where(c => c.FranchiseId == franchiseId).ToList();
                    characters.AddRange(currentCharacters);
                }
            }

            Random random = new Random();

            int randomIndex = 0;
            int randomIndex2 = 0;


            do
            {
                 randomIndex = random.Next(characters.Count);
                 randomIndex2 = random.Next(characters.Count);

            }
            while (randomIndex == randomIndex2);


            Character character = characters[randomIndex];
            Character character2 = characters[randomIndex2];


            List<Character> twoCharacters = new List<Character>()
            {
                character, character2
            };

            string stringFranchiseIds = string.Join(",", franchiseIds);
            VotingViewModel votingViewModel = new VotingViewModel()
            {
                FranchiseIds = stringFranchiseIds,
                Characters = twoCharacters,
            };



            return View(votingViewModel);
        }

        private async Task ResetCharacterDataAndDeleteMatches()
        {
            List<Character> characters = await _context.Characters.ToListAsync();
            foreach (Character character in characters) 
            {
                character.VoteCount = 0;
            }

            List<Match> matches = await _context.Matches.ToListAsync();


            _context.Matches.RemoveRange(matches);
            //foreach (Match match in matches)
            //{
            //    _context.Matches.Remove(match);
            //} //this does the same thing
            await _context.SaveChangesAsync();

        }

        //Action for when the first character wins
        [HttpPost]
        public async Task<IActionResult> MatchMakingFirstCharacter([Bind("Id", "FirstCharacterId", "SecondCharacterId", "FranchiseIds")] VotingViewModel characterMatch)
        {
            Character character1 = await _context.Characters.FirstOrDefaultAsync(c => c.Id == characterMatch.FirstCharacterId);
            Character character2 = await _context.Characters.FirstOrDefaultAsync(c => c.Id == characterMatch.SecondCharacterId);

            character1.VoteCount += 1;

            Match match = new Match()
            {
                CharacterThatWonId = character1.Id,
                CharacterThatLostId = character2.Id
            };

            _context.Matches.Add(match);
            _context.SaveChanges();
            //_context.

            // TO DO: Method that figures out if the matches are done


            bool matchesAreDone = CheckIfMatchesAreDone(characterMatch);

            if (matchesAreDone) 
            {
                return RedirectToAction("Index", "Summary", new { StringFranchiseIds = characterMatch.FranchiseIds });
            }

            VotingViewModel votingViewModel = NextCharactersToMatch(characterMatch);

            return View("Index", votingViewModel);
        }

        private bool CheckIfMatchesAreDone(VotingViewModel characterMatch)
        {
            List<Character> characters = new List<Character>();

            List<int> franchiseIds = characterMatch.FranchiseIds.Split(',').Select(int.Parse).ToList();
            foreach (int franchiseId in franchiseIds)
            {
                if (franchiseId != 0)
                {
                    List<Character> currentCharacters = _context.Characters.Where(c => c.FranchiseId == franchiseId).ToList();
                    characters.AddRange(currentCharacters);
                }
            }

            List<Match> matches = _context.Matches.ToList();

            int totalMatches = matches.Count;

            int totalCharacters = characters.Count;

            int thresholdNumber = (totalCharacters * (totalCharacters - 1)) / 2;

            bool matchesDone = totalMatches == thresholdNumber;

            return matchesDone;
        }

        private VotingViewModel NextCharactersToMatch(VotingViewModel characterMatch)
        {
            List<Character> characters = new List<Character>();
            List<int> franchiseIds = characterMatch.FranchiseIds.Split(',').Select(int.Parse).ToList();

            foreach (int franchiseId in franchiseIds)
            {
                if (franchiseId != 0)
                {
                    List<Character> currentCharacters = _context.Characters.Where(c => c.FranchiseId == franchiseId).ToList();
                    characters.AddRange(currentCharacters);
                }
            }

            Random random = new Random();

            int randomIndex = 0;
            int randomIndex2 = 0;
            bool matchExists = false;
            Character newCharacter1;
            Character newCharacter2;


            do
            {
                randomIndex = random.Next(characters.Count);
                randomIndex2 = random.Next(characters.Count);

                newCharacter1 = characters[randomIndex];
                newCharacter2 = characters[randomIndex2];


                matchExists = MatchCheck(newCharacter1, newCharacter2);

            }
            while (matchExists || randomIndex == randomIndex2);


            List<Character> twoCharacters = new List<Character>()
            {
                newCharacter1, newCharacter2
            };

            string stringFranchiseIds = string.Join(",", franchiseIds);
            VotingViewModel votingViewModel = new VotingViewModel()
            {
                FranchiseIds = stringFranchiseIds,
                Characters = twoCharacters,
            };
            return votingViewModel;
        }

        /// <summary>
        /// This checks if the first character has beaten the second character before
        /// </summary>
        /// <param name="newCharacter1"></param>
        /// <param name="newCharacter2"></param>
        /// <returns></returns>
        private bool MatchCheck(Character newCharacter1, Character newCharacter2)
        {
            Match match1 = new Match()
            {
                CharacterThatWonId = newCharacter1.Id,
                CharacterThatLostId = newCharacter2.Id,
            };

            Match match2 = new Match()
            {
                CharacterThatWonId = newCharacter2.Id,
                CharacterThatLostId = newCharacter1.Id,
            };

            List<Match> allDatabaseMatches = _context.Matches.ToList();

            bool matchExists1 = allDatabaseMatches
                .Any(m => m.CharacterThatWonId == match1.CharacterThatWonId && m.CharacterThatLostId == match1.CharacterThatLostId);

            bool matchExists2 = allDatabaseMatches
               .Any(m => m.CharacterThatWonId == match2.CharacterThatWonId && m.CharacterThatLostId == match2.CharacterThatLostId);

            if (matchExists1 == true)
            {
                return matchExists1;
            }
            else if (matchExists2 == true) 
            {
                return matchExists2;
            }
            else
            {
                return false;
            }
        }


        //Action for when the first character wins
        [HttpPost]
        public async Task<IActionResult> MatchMakingSecondCharacter([Bind("Id", "FirstCharacterId", "SecondCharacterId", "FranchiseIds")] VotingViewModel characterMatch)
        {
            Character character1 = await _context.Characters.FirstOrDefaultAsync(c => c.Id == characterMatch.FirstCharacterId);
            Character character2 = await _context.Characters.FirstOrDefaultAsync(c => c.Id == characterMatch.SecondCharacterId);

            character2.VoteCount += 1;

            Match match = new Match()
            {
                CharacterThatWonId = character2.Id,
                CharacterThatLostId = character1.Id
            };

            _context.Matches.Add(match);
            _context.SaveChanges();

            // TO DO: Method that figures out if the matches are done


            bool matchesAreDone = CheckIfMatchesAreDone(characterMatch);

            if (matchesAreDone)
            {
                return RedirectToAction("Index", "Summary", new { StringFranchiseIds = characterMatch.FranchiseIds });
            }

            VotingViewModel votingViewModel = NextCharactersToMatch(characterMatch);

            return View("Index", votingViewModel);
        }
    }
}

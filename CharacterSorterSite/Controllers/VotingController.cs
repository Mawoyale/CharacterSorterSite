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

            string stringFranchiseIds = string.Join(",", franchiseIds); ;
            VotingViewModel votingViewModel = new VotingViewModel()
            {
                FranchiseIds = stringFranchiseIds,
                Characters = twoCharacters,
            };



            return View(votingViewModel);
        }



        //[HttpGet]
        //public async Task<IActionResult> Index(VotingController voting)
        //{
        //    VoteCount +=1



        //}

        [HttpPost]
        public async Task<IActionResult> MatchMakingFirstCharacter([Bind("Id", "FirstCharacterId", "SecondCharacterId", "FranchiseIds")] VotingViewModel characterMatch)
        {
            Character character1 = await _context.Characters.FirstOrDefaultAsync(c => c.Id == characterMatch.FirstCharacterId);
            Character character2 = await _context.Characters.FirstOrDefaultAsync(c => c.Id == characterMatch.SecondCharacterId);

            character1.VoteCount += 1;

            Match match = new Match()
            {
                CharacterThatWonId = character1.Id,
                CharacterThatLostId= character2.Id
            };

            _context.Matches.Add(match);
            _context.SaveChanges();
            //_context.




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


            do
            {
                randomIndex = random.Next(characters.Count);
                randomIndex2 = random.Next(characters.Count);

            }
            while (randomIndex == randomIndex2);


            Character newCharacter1 = characters[randomIndex];
            Character newCharacter2 = characters[randomIndex2];


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

            return View("Index", votingViewModel);
        }



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


            do
            {
                randomIndex = random.Next(characters.Count);
                randomIndex2 = random.Next(characters.Count);

            }
            while (randomIndex == randomIndex2);


            Character newCharacter1 = characters[randomIndex];
            Character newCharacter2 = characters[randomIndex2];


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

            return View("Index", votingViewModel);
        }
    }
}

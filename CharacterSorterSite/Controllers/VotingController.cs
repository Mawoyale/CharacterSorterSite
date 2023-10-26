using CharacterSorterSite.Data;
using CharacterSorterSite.Models;
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
        public async Task<IActionResult> Index(FranchiseHelper request)
        {
            List<int> franchiseIds = request.Ids.Split(',').Select(int.Parse).ToList();

            List<Character> characters = new List<Character>();


            foreach (int franchiseId in franchiseIds)
            {
                List<Character> currentCharacters = _context.Characters.Where(c => c.FranchiseId == franchiseId).ToList();
                characters.AddRange(currentCharacters);
            }

            Random random = new Random();

            int randomIndex = random.Next(characters.Count);
            int randomIndex2 = random.Next(characters.Count);


            Character character = characters[randomIndex];
            Character character2 = characters[randomIndex2];

             
            List<Character> twoCharacters = new List<Character>()
            {
                character, character2
            };


            return View(twoCharacters);
        }



        public class FranchiseHelper
        {
            public string Ids { get; set; }
        }
    }
}

using CharacterSorterSite.Data;
using CharacterSorterSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSorterSite.Controllers
{
    public class SummaryController : Controller
    {
        private readonly CharacterContext _context;

        public SummaryController(CharacterContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Summary/{stringFranchiseIds}")]
        public IActionResult Index(string stringFranchiseIds)
        {
            List<Character> characters = new List<Character>();

            List<int> franchiseIds = stringFranchiseIds.Split(',').Select(int.Parse).ToList();

            foreach (int franchiseId in franchiseIds)
            {
                if (franchiseId != 0)
                {
                    List<Character> currentCharacters = _context.Characters.Where(c => c.FranchiseId == franchiseId).ToList();
                    characters.AddRange(currentCharacters);
                }
            }

            characters = characters.OrderByDescending(c => c.VoteCount).ToList();

            return View(characters);
        }
    }
}

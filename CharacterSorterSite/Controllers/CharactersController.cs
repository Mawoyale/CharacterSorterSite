using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using CharacterSorterSite.Data;
using CharacterSorterSite.Models;

namespace CharacterSorterSite.Controllers
{
    public class CharactersController : Controller
    {
        private readonly CharacterContext _context;

        public CharactersController(CharacterContext context)
        {
            _context = context;
        }


        // GET: Characters
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Characters.ToListAsync());
        }
        private bool CharacterExists(int Id)
        {
            return _context.Characters.Any(c => c.Id == Id);
        }

        // GET: Characters/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Post: Characters/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Genre,Franchise,Alignment,Source,Match,Character")] Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Add(character);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(character);
        }
        // GET: Characters/Edit/{Id}
        [HttpGet]
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null || _context.Characters == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(Id);

            if (character == null) return NotFound();

            return View(character);
        }

        // POST: Characters/Edit/{Id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,Genre,Franchise,Alignment,Source,Match,Character")] Character character)
        {
            if (Id != character.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(character);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //  CharacterExists() method will be added later
                    if (!CharacterExists(character.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(character);
        }
    }
}

//page 27 check notion
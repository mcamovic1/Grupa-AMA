using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AMA_cosmetics.Data;
using AMA_cosmetics.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AMA_cosmetics.Controllers
{
    public class KorpaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KorpaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Korpa
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Korpa.Include(k => k.Proizvod);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Korpa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korpa = await _context.Korpa
                .Include(k => k.Proizvod)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (korpa == null)
            {
                return NotFound();
            }

            return View(korpa);
        }

        // GET: Korpa/Create
        public IActionResult Create()
        {
            ViewData["IDProizvod"] = new SelectList(_context.Prizvod, "ID", "ID");
            return View();
        }

        // POST: Korpa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IDProizvod,UserName,IDKorisnik,Cijena,kolicina")] Korpa korpa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(korpa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDProizvod"] = new SelectList(_context.Prizvod, "ID", "ID", korpa.IDProizvod);
            return View(korpa);
        }

        // GET: Korpa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korpa = await _context.Korpa.FindAsync(id);
            if (korpa == null)
            {
                return NotFound();
            }
            ViewData["IDProizvod"] = new SelectList(_context.Prizvod, "ID", "ID", korpa.IDProizvod);
            return View(korpa);
        }

        // POST: Korpa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IDProizvod,UserName,IDKorisnik,Cijena,kolicina")] Korpa korpa)
        {
            if (id != korpa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(korpa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KorpaExists(korpa.Id))
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
            ViewData["IDProizvod"] = new SelectList(_context.Prizvod, "ID", "ID", korpa.IDProizvod);
            return View(korpa);
        }

        // GET: Korpa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korpa = await _context.Korpa
                .Include(k => k.Proizvod)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (korpa == null)
            {
                return NotFound();
            }

            return View(korpa);
        }

        // POST: Korpa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var korpa = await _context.Korpa.FindAsync(id);
            _context.Korpa.Remove(korpa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KorpaExists(int id)
        {
            return _context.Korpa.Any(e => e.Id == id);
        }
        public async Task<IActionResult> Add(int id)
        {
            var proizvod = await _context.Prizvod.FindAsync(id);
            if (proizvod != null)
            {
                //var userName = _context.GetUserId(User);
                //var userId = _context.Users.Where(u => u.UserName== User.Identity.Name).Select(u => u.Id).FirstOrDefault();
                //int userIdInt = int.Parse(userId);
                var cartItem = _context.Korpa.FirstOrDefault(c => c.IDProizvod == id && c.UserName == User.Identity.Name);
                if (cartItem != null)
                {
                    // Ako proizvod već postoji u korpi, povećajte količinu
                    cartItem.kolicina += 1;
                }
                else
                {
                    // Ako proizvod ne postoji u korpi, dodajte ga
                    var cartItem1 = new Korpa
                    {
                        //IDKorisnik = userIdInt,
                        IDProizvod = id,
                        Proizvod= await _context.Prizvod.FindAsync(id),
                        UserName = User.Identity.Name,
                        kolicina = 1,
                        Cijena = (int)proizvod.Cijena
                    };
                    _context.Korpa.Add(cartItem1);


                    _context.SaveChanges();
                }
            }
            //return View();
            List<Korpa> ProizvodiUKorpi = _context.Korpa.Where(p => p.UserName==User.Identity.Name).ToList();
            return View(ProizvodiUKorpi);

        }
    }
}

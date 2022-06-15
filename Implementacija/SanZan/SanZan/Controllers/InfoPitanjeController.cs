using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SanZan.Data;
using SanZan.Models;

namespace SanZan.Controllers
{
    public class InfoPitanjeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InfoPitanjeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InfoPitanje
        public async Task<IActionResult> Index()
        {
            return View(await _context.InfoPitanje.ToListAsync());
        }

        // GET: InfoPitanje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoPitanje = await _context.InfoPitanje
                .FirstOrDefaultAsync(m => m.IDPitanja == id);
            if (infoPitanje == null)
            {
                return NotFound();
            }

            return View(infoPitanje);
        }

        // GET: InfoPitanje/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InfoPitanje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPitanja,Pitanje,Odgovor")] InfoPitanje infoPitanje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(infoPitanje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(infoPitanje);
        }

        // GET: InfoPitanje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoPitanje = await _context.InfoPitanje.FindAsync(id);
            if (infoPitanje == null)
            {
                return NotFound();
            }
            return View(infoPitanje);
        }

        // POST: InfoPitanje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDPitanja,Pitanje,Odgovor")] InfoPitanje infoPitanje)
        {
            if (id != infoPitanje.IDPitanja)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoPitanje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoPitanjeExists(infoPitanje.IDPitanja))
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
            return View(infoPitanje);
        }

        // GET: InfoPitanje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoPitanje = await _context.InfoPitanje
                .FirstOrDefaultAsync(m => m.IDPitanja == id);
            if (infoPitanje == null)
            {
                return NotFound();
            }

            return View(infoPitanje);
        }

        // POST: InfoPitanje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var infoPitanje = await _context.InfoPitanje.FindAsync(id);
            _context.InfoPitanje.Remove(infoPitanje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfoPitanjeExists(int id)
        {
            return _context.InfoPitanje.Any(e => e.IDPitanja == id);
        }
    }
}

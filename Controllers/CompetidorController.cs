using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaRodeio.Data;
using SistemaRodeio.Models;

namespace SistemaRodeio.Controllers
{
    public class CompetidorController : Controller
    {
        private readonly AppDbContext _context;

        public CompetidorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Competidor
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Competidores.Include(c => c.cidade);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Competidor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competidor = await _context.Competidores
                .Include(c => c.cidade)
                .FirstOrDefaultAsync(m => m.id == id);
            if (competidor == null)
            {
                return NotFound();
            }

            return View(competidor);
        }

        // GET: Competidor/Create
        public IActionResult Create()
        {
            ViewData["cidadeid"] = new SelectList(_context.Cidades, "id", "descricao");
            return View();
        }

        // POST: Competidor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,cidadeid,idade,vitorias")] Competidor competidor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(competidor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["cidadeid"] = new SelectList(_context.Cidades, "id", "descricao", competidor.cidadeid);
            return View(competidor);
        }

        // GET: Competidor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competidor = await _context.Competidores.FindAsync(id);
            if (competidor == null)
            {
                return NotFound();
            }
            ViewData["cidadeid"] = new SelectList(_context.Cidades, "id", "descricao", competidor.cidadeid);
            return View(competidor);
        }

        // POST: Competidor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,cidadeid,idade,vitorias")] Competidor competidor)
        {
            if (id != competidor.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competidor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetidorExists(competidor.id))
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
            ViewData["cidadeid"] = new SelectList(_context.Cidades, "id", "descricao", competidor.cidadeid);
            return View(competidor);
        }

        // GET: Competidor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competidor = await _context.Competidores
                .Include(c => c.cidade)
                .FirstOrDefaultAsync(m => m.id == id);
            if (competidor == null)
            {
                return NotFound();
            }

            return View(competidor);
        }

        // POST: Competidor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var competidor = await _context.Competidores.FindAsync(id);
            if (competidor != null)
            {
                _context.Competidores.Remove(competidor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetidorExists(int id)
        {
            return _context.Competidores.Any(e => e.id == id);
        }
    }
}

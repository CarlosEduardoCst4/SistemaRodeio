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
    public class TipoAnimalController : Controller
    {
        private readonly AppDbContext _context;

        public TipoAnimalController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TipoAnimal
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposAnimais.ToListAsync());
        }

        // GET: TipoAnimal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAnimal = await _context.TiposAnimais
                .FirstOrDefaultAsync(m => m.id == id);
            if (tipoAnimal == null)
            {
                return NotFound();
            }

            return View(tipoAnimal);
        }

        // GET: TipoAnimal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoAnimal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao")] TipoAnimal tipoAnimal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoAnimal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAnimal);
        }

        // GET: TipoAnimal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAnimal = await _context.TiposAnimais.FindAsync(id);
            if (tipoAnimal == null)
            {
                return NotFound();
            }
            return View(tipoAnimal);
        }

        // POST: TipoAnimal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descricao")] TipoAnimal tipoAnimal)
        {
            if (id != tipoAnimal.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoAnimal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoAnimalExists(tipoAnimal.id))
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
            return View(tipoAnimal);
        }

        // GET: TipoAnimal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAnimal = await _context.TiposAnimais
                .FirstOrDefaultAsync(m => m.id == id);
            if (tipoAnimal == null)
            {
                return NotFound();
            }

            return View(tipoAnimal);
        }

        // POST: TipoAnimal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAnimal = await _context.TiposAnimais.FindAsync(id);
            if (tipoAnimal != null)
            {
                _context.TiposAnimais.Remove(tipoAnimal);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAnimalExists(int id)
        {
            return _context.TiposAnimais.Any(e => e.id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using L01P02_2022RL652.Models;

namespace L01P02_2022RL652.Controllers
{
    public class PublicacionesController : Controller
    {
        private readonly blogdbContext _context;

        public PublicacionesController(blogdbContext context)
        {
            _context = context;
        }

        // GET: Publicaciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.publicaciones.ToListAsync());
        }

        // GET: Publicaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicaciones = await _context.publicaciones
                .FirstOrDefaultAsync(m => m.publicacionId == id);
            if (publicaciones == null)
            {
                return NotFound();
            }

            return View(publicaciones);
        }

        // GET: Publicaciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publicaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("publicacionId,titulo,descripcion,usuarioId")] Publicaciones publicaciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publicaciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publicaciones);
        }

        // GET: Publicaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicaciones = await _context.publicaciones.FindAsync(id);
            if (publicaciones == null)
            {
                return NotFound();
            }
            return View(publicaciones);
        }

        // POST: Publicaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("publicacionId,titulo,descripcion,usuarioId")] Publicaciones publicaciones)
        {
            if (id != publicaciones.publicacionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publicaciones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublicacionesExists(publicaciones.publicacionId))
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
            return View(publicaciones);
        }

        // GET: Publicaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publicaciones = await _context.publicaciones
                .FirstOrDefaultAsync(m => m.publicacionId == id);
            if (publicaciones == null)
            {
                return NotFound();
            }

            return View(publicaciones);
        }

        // POST: Publicaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publicaciones = await _context.publicaciones.FindAsync(id);
            if (publicaciones != null)
            {
                _context.publicaciones.Remove(publicaciones);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublicacionesExists(int id)
        {
            return _context.publicaciones.Any(e => e.publicacionId == id);
        }
    }
}

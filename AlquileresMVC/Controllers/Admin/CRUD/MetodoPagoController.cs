using AlquileresMVC.Data;
using AlquileresMVC.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlquileresMVC.Controllers.Admin.CRUD
{
    public class MetodoPagoController : Controller
    {
        private readonly AdminDbContext _context;

        public MetodoPagoController(AdminDbContext context)
        {
            _context = context;
        }

        // GET: MetodoPago
        public async Task<IActionResult> Index()
        {
            return View(await _context.MetodoPago.ToListAsync());
        }

        // GET: MetodoPago/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MetodoPago/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MetodoPago metodoPago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(metodoPago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(metodoPago);
        }

        // GET: MetodoPago/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metodoPago = await _context.MetodoPago.FindAsync(id);
            if (metodoPago == null)
            {
                return NotFound();
            }
            return View(metodoPago);
        }

        // POST: MetodoPago/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MetodoPago metodoPago)
        {
            if (id != metodoPago.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(metodoPago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetodoPagoExists(metodoPago.Id))
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
            return View(metodoPago);
        }

        // GET: MetodoPago/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metodoPago = await _context.MetodoPago
               .FirstOrDefaultAsync(m => m.Id == id);
            if (metodoPago == null)
            {
                return NotFound();
            }

            return View(metodoPago);
        }

        // POST: MetodoPago/Delete/5
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var metodoPago = await _context.MetodoPago.FindAsync(id);
            _context.MetodoPago.Remove(metodoPago);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "MetodoPago");
        }

        private bool MetodoPagoExists(int id)
        {
            return _context.MetodoPago.Any(e => e.Id == id);
        }
    }
}
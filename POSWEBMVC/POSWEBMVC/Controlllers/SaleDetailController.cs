using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using POSWEBMVC.Data;
using POSWEBMVC.Models;

namespace POSWEBMVC.Controllers
{
    public class SaleDetailController : Controller
    {
        private readonly PosContext _context;

        public SaleDetailController(PosContext context)
        {
            _context = context;
        }

        // GET: SaleDetail
        public async Task<IActionResult> Index()
        {
            var posContext = _context.SaleDetails.Include(s => s.Product).Include(s => s.Sale);
            return View(await posContext.ToListAsync());
        }

        // GET: SaleDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SaleDetails
                .Include(s => s.Product)
                .Include(s => s.Sale)
                .FirstOrDefaultAsync(m => m.SaleDetailID == id);
            if (saleDetail == null)
            {
                return NotFound();
            }

            return View(saleDetail);
        }

        // GET: SaleDetail/Create
        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name");
            ViewData["SaleID"] = new SelectList(_context.Sales, "SaleID", "SaleID");
            return View();
        }

        // POST: SaleDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SaleDetailID,SaleID,ProductID,Quantity,Discount,Total")] SaleDetail saleDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saleDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name", saleDetail.ProductID);
            ViewData["SaleID"] = new SelectList(_context.Sales, "SaleID", "SaleID", saleDetail.SaleID);
            return View(saleDetail);
        }

        // GET: SaleDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SaleDetails.FindAsync(id);
            if (saleDetail == null)
            {
                return NotFound();
            }
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name", saleDetail.ProductID);
            ViewData["SaleID"] = new SelectList(_context.Sales, "SaleID", "SaleID", saleDetail.SaleID);
            return View(saleDetail);
        }

        // POST: SaleDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SaleDetailID,SaleID,ProductID,Quantity,Discount,Total")] SaleDetail saleDetail)
        {
            if (id != saleDetail.SaleDetailID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saleDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaleDetailExists(saleDetail.SaleDetailID))
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
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "Name", saleDetail.ProductID);
            ViewData["SaleID"] = new SelectList(_context.Sales, "SaleID", "SaleID", saleDetail.SaleID);
            return View(saleDetail);
        }

        // GET: SaleDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SaleDetails
                .Include(s => s.Product)
                .Include(s => s.Sale)
                .FirstOrDefaultAsync(m => m.SaleDetailID == id);
            if (saleDetail == null)
            {
                return NotFound();
            }

            return View(saleDetail);
        }

        // POST: SaleDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saleDetail = await _context.SaleDetails.FindAsync(id);
            _context.SaleDetails.Remove(saleDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleDetailExists(int id)
        {
            return _context.SaleDetails.Any(e => e.SaleDetailID == id);
        }
    }
}

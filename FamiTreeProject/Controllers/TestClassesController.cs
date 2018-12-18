using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FamiTreeProject.Models;

namespace FamiTreeProject.Controllers
{
    public class TestClassesController : Controller
    {
        private readonly TestClassDataC _context;

        public TestClassesController(TestClassDataC context)
        {
            _context = context;
        }

        // GET: TestClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subjects.ToListAsync());
        }

        // GET: TestClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testClass = await _context.Subjects
                .FirstOrDefaultAsync(m => m.id == id);
            if (testClass == null)
            {
                return NotFound();
            }

            return View(testClass);
        }

        // GET: TestClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TestClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,parent")] TestClass testClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testClass);
        }

        // GET: TestClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testClass = await _context.Subjects.FindAsync(id);
            if (testClass == null)
            {
                return NotFound();
            }
            return View(testClass);
        }

        // POST: TestClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,parent")] TestClass testClass)
        {
            if (id != testClass.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestClassExists(testClass.id))
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
            return View(testClass);
        }

        // GET: TestClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testClass = await _context.Subjects
                .FirstOrDefaultAsync(m => m.id == id);
            if (testClass == null)
            {
                return NotFound();
            }

            return View(testClass);
        }

        // POST: TestClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testClass = await _context.Subjects.FindAsync(id);
            _context.Subjects.Remove(testClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestClassExists(int id)
        {
            return _context.Subjects.Any(e => e.id == id);
        }
    }
}

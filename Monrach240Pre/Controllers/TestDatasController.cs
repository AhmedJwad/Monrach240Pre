using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Monrach240Pre.Data;
using Monrach240Pre.Data.Entities;

namespace Monrach240Pre.Controllers
{
    public class TestDatasController : Controller
    {
        private readonly DataContext _context;

        public TestDatasController(DataContext context)
        {
            _context = context;
        }

        // GET: TestDatas
        public async Task<IActionResult> Index()
        {
              return _context.Datasets != null ? 
                          View(await _context.Datasets.ToListAsync()) :
                          Problem("Entity set 'DataContext.Datasets'  is null.");
        }

        // GET: TestDatas/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null || _context.Datasets == null)
            {
                return NotFound();
            }

            var testData = await _context.Datasets
                .FirstOrDefaultAsync(m => m.ID == id);
            if (testData == null)
            {
                return NotFound();
            }

            return View(testData);
        }

        // GET: TestDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TestDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TIMESTAMP,DATE_TIME_STAMP,DATA_SOURCE_NAME,DEVICE_ID,PATIENT_SEQ_NUM,PATIENT_ID,PATIENT_NAME,PATIENT_NAME_LAST,PATIENT_NAME_MIDDLE,PATIENT_NAME_FIRST,PATIENT_NAME_SEX,PATIENT_ADDRESS,PATIENT_PHONE,PATIENT_RACE,RESULT_SEQ_NUM,RESULT_TEST_ID,RESULT_TEST_ID1,RESULT_TEST_ID2,RESULT_TEST_ID3,RESULT_TEST_ID4,RESULT_VALUE,RESULT_UNIT,RESULT_ABNORMAL,RESULT_STATUS,RESULT_OPERATOR_ID")] TestData testData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testData);
        }

        // GET: TestDatas/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null || _context.Datasets == null)
            {
                return NotFound();
            }

            var testData = await _context.Datasets.FindAsync(id);
            if (testData == null)
            {
                return NotFound();
            }
            return View(testData);
        }

        // POST: TestDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("ID,TIMESTAMP,DATE_TIME_STAMP,DATA_SOURCE_NAME,DEVICE_ID,PATIENT_SEQ_NUM,PATIENT_ID,PATIENT_NAME,PATIENT_NAME_LAST,PATIENT_NAME_MIDDLE,PATIENT_NAME_FIRST,PATIENT_NAME_SEX,PATIENT_ADDRESS,PATIENT_PHONE,PATIENT_RACE,RESULT_SEQ_NUM,RESULT_TEST_ID,RESULT_TEST_ID1,RESULT_TEST_ID2,RESULT_TEST_ID3,RESULT_TEST_ID4,RESULT_VALUE,RESULT_UNIT,RESULT_ABNORMAL,RESULT_STATUS,RESULT_OPERATOR_ID")] TestData testData)
        {
            if (id != testData.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestDataExists(testData.ID))
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
            return View(testData);
        }

        // GET: TestDatas/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null || _context.Datasets == null)
            {
                return NotFound();
            }

            var testData = await _context.Datasets
                .FirstOrDefaultAsync(m => m.ID == id);
            if (testData == null)
            {
                return NotFound();
            }

            return View(testData);
        }

        // POST: TestDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            if (_context.Datasets == null)
            {
                return Problem("Entity set 'DataContext.Datasets'  is null.");
            }
            var testData = await _context.Datasets.FindAsync(id);
            if (testData != null)
            {
                _context.Datasets.Remove(testData);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestDataExists(decimal id)
        {
          return (_context.Datasets?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

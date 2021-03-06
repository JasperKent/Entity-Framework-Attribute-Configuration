﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookLibrary;
using EFCoreWeb.Models;

namespace EFCoreWeb.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksContext _context;

        public BooksController(BooksContext context)
        {
            _context = context;
        }

        //// GET: Books
        //public async Task<IActionResult> Index()
        //{
        //    var books = await _context.Books.ToModel().ToListAsync();

        //    return View(books);
        //}

        //// GET: Books/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    var book = await _context.Books.ToModel().SingleOrDefaultAsync(b => b.Id == id);

        //    if (book == null)
        //        return NotFound();
        //    else
        //        return View(book);
        //}

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,YearOfPublication")] Book book)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(book);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(book);
        //}

        // GET: Books/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    var book = await _context.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id);

        //    if (book == null)
        //        return NotFound();
        //    else
        //        return View(book);

        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, Book book)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(book);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    else
        //        return View(book);
        //}

        // GET: Books/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var book = await _context.Books
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(book);
        //}

        // POST: Books/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var book = await _context.Books.FindAsync(id);
        //    _context.Books.Remove(book);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BookExists(int id)
        //{
        //    return _context.Books.Any(e => e.Id == id);
        //}
    }
}

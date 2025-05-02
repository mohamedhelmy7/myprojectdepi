using DEPI_Library.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

public class BorrowsController : Controller
{
    private readonly LibraryContext _context;

    public BorrowsController(LibraryContext context)
    {
        _context = context;
    }

    // عرض الاستعارات
    public IActionResult Index()
    {
        // جلب الاستعارات مع تضمين الكتاب والمستعير
        var borrows = _context.Borrows
            .Include(b => b.Book)    // تضمين الكتاب
            .Include(b => b.User)    // تضمين المستعير
            .ToList();

        return View(borrows);
    }

    // عرض صفحة إنشاء الاستعارة
    public IActionResult Create()
    {
        // تحميل الكتب والمستخدمين للاختيار
        ViewBag.Books = new SelectList(_context.Books, "BookId", "Title");
        ViewBag.Users = new SelectList(_context.Users, "UserId", "Name");
        return View();
    }

    // معالجة البيانات بعد إرسال استمارة الاستعارة
    [HttpPost]
    public IActionResult Create(Borrow borrow)
    {
        if (ModelState.IsValid)
        {
            borrow.BorrowDate = DateTimeOffset.Now;  // تسجيل تاريخ الاستعارة الحالي
            _context.Borrows.Add(borrow);           // إضافة الاستعارة إلى قاعدة البيانات
            _context.SaveChanges();                 // حفظ التغييرات
            return RedirectToAction("Index");       // إعادة توجيه إلى تقرير الاستعارات
        }

        // إذا كانت البيانات غير صالحة، إعادة تحميل الكتب والمستعيرين
        ViewBag.Books = new SelectList(_context.Books, "BookId", "Title", borrow.BookId);
        ViewBag.Users = new SelectList(_context.Users, "UserId", "Name", borrow.UserId);
        return View(borrow);
    }
}

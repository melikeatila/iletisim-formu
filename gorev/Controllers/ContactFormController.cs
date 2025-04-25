using Microsoft.AspNetCore.Mvc;
using gorev.Models;
using gorev.Data;

namespace gorev.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactFormController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.ContactForms.Add(form);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Success");
                }
                catch (Exception ex)
                {
                    // Hata loglama yapılabilir
                    ModelState.AddModelError("", "Veritabanına kayıt sırasında bir hata oluştu.");
                }
            }

            return View(form);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}

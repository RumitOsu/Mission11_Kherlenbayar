using Microsoft.AspNetCore.Mvc;
using Mission11_Kherlenbayar.Models;
using Microsoft.EntityFrameworkCore; // Add this line

namespace Mission11_Kherlenbayar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int PageSize = 10; // Define the page size

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int bookPage = 1)
        {
            var books = await PaginatedList<Book>.CreateAsync(_context.Books.AsNoTracking(), bookPage, PageSize);

            // Pass the books to the view
            return View(books);
        }
    }
}

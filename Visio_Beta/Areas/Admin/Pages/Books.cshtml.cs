using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Visio_Beta.Data;
using Visio_Beta.Data.Models;

namespace Visio_Beta.Areas.Admin.Pages
{
    public class BooksModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public BooksModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
        }
    }
}

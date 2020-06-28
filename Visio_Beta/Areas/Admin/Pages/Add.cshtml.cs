using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Visio_Beta.Data;
using Visio_Beta.Data.Models;

namespace Visio_Beta.Areas.Admin.Pages
{
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public AddModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        [BindProperty]
        public Category Category { get; set; }

        public FileModel FileModel { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

            }
            return RedirectToPage();
        }
    }

    public class FileModel
    {
        public IFormFile form { get; set; }
    }
}

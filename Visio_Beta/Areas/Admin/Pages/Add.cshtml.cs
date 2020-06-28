using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
                //create scop for buffer stream in memory
                using (var memStream = new MemoryStream())
                {
                    //copy file from form to buffer stream 
                    await FileModel.form.CopyToAsync(memStream);

                    //check if file size is under 4Mo
                    if(memStream.Length < 4194304)
                    {
                        //create new book
                        var NewBook = new Book
                        {
                            Title = Book.Title,
                            Author = Book.Author,
                            Year = Book.Year,
                            Pages = Book.Pages,
                            Edition = Book.Edition,
                            Add_date = Book.Add_date,
                            Content = memStream.ToArray()
                        };

                        //save it to book list
                        await _db.Books.AddAsync(NewBook);

                        //save to Database
                        await _db.SaveChangesAsync();
                    }
                }
                //wait 2 sec before redirecting to books index page
                await Task.Delay(2000);
                return RedirectToPage("Books","Admin","Index");
            }

            await Task.Delay(2000);
            return RedirectToPage();
        }
    }

    public class FileModel
    {
        public IFormFile form { get; set; }
    }
}

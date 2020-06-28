using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Visio_Beta.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnGetLivre()
        {
            return RedirectToPage("Books", "Admin","Index");
        }
        
        public IActionResult OnGetProduits()
        {
            return RedirectToPage("Produits", "Admin","Pages");
        }
        
        public IActionResult OnGetCategory()
        {
            return RedirectToPage("Category", "Admin", "Pages");
        }
        
        public IActionResult OnGetUsers()
        {
            return RedirectToPage("Produits", "Admin", "Pages");
        }


    }
}

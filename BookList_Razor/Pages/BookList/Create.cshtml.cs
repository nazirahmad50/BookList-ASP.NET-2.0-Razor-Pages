using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_Razor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private ApplicaitonDbContext _db;
        [TempData]
        public string Message { get; set; }

        //using dependency injeciton
        public CreateModel(ApplicaitonDbContext db)
        {
            _db = db;

        }

        //bind the property to the handler or method
        //instead of using 'OnPost(Book book)'
        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            else
            {
                _db.Books.Add(Book);
                await _db.SaveChangesAsync();

                Message = "New Book Added";

                return RedirectToPage("Index");

            }
        }
    }
}
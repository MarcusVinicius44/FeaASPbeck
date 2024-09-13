using FEAasp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FEAasp.Pages
{
    public class ContatoModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context;
        public ContatoModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public contatos contato { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.contato.Add(contato);
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPDemo.Data;
using ASPDemo.Models;

namespace ASPDemo.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly ASPDemo.Data.ChinookContext _context;

        public CreateModel(ASPDemo.Data.ChinookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SupportRepId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId");
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Customers == null || Customer == null)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

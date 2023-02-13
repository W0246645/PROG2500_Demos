using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPDemo.Data;
using ASPDemo.Models;

namespace ASPDemo.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly ASPDemo.Data.ChinookContext _context;

        public IndexModel(ASPDemo.Data.ChinookContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customer = await _context.Customers
                .Include(c => c.SupportRep).ToListAsync();
            }
        }
    }
}

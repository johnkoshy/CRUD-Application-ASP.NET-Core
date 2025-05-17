using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_APP.Data;
using CRUD_APP.Model;

namespace CRUD_APP.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_APP.Data.CRUD_APPContext _context;

        public IndexModel(CRUD_APP.Data.CRUD_APPContext context)
        {
            _context = context;
        }

        public new IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }
    }
}

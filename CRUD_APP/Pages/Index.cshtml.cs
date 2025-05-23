using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD_APP.Model;

namespace CRUD_APP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_APP.Data.CRUD_APPContext _context;

        public IndexModel(CRUD_APP.Data.CRUD_APPContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
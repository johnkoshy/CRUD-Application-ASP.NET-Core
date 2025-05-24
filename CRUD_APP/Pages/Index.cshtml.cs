using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD_APP.Model;
using CRUD_APP.Data;

namespace CRUD_APP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_APPContext _context;

        public IndexModel(CRUD_APPContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                Users = await _context.Users.ToListAsync();
            }
            else
            {
                Users = new List<User>();
            }
        }
    }
}
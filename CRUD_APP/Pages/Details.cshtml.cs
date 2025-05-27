using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_APP.Data;
using CRUD_APP.Model;

namespace CRUD_APP.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly CRUD_APPContext _context;

        public DetailsModel(CRUD_APPContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            User = user;
            return Page();
        }
    }
}
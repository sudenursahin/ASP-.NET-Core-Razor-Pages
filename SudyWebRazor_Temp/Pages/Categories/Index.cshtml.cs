using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SudyWebRazor_Temp.Data;
using SudyWebRazor_Temp.Models;

namespace SudyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }    
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;  
        }


        public void OnGet()
        {
           CategoryList = _db.Categories.ToList();


        }
    }
}

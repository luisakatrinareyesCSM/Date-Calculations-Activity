using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Luisa.DateCalculator.Pages
{
    public class DatesModel : PageModel
    {
        public void OnGet()
        {
        }
        public class Datecalculator {
            public DateTime date;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PranavPieShop.Pages
{
    public class CheckoutCompletedPageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["CheckoutCompleteMessage"] = "Thanks for your order. You will enjoy our delicious pies!";
        }
    }
}

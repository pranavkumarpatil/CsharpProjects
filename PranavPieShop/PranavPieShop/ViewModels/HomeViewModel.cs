using PranavPieShop.Models;

namespace PranavPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public HomeViewModel(IEnumerable<Pie> pieOfTheWeek)
        {
            PiesOfTheWeek = pieOfTheWeek;
        }
    }
}

using PranavPieShop.Models;

namespace PranavPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }
        public string? CuurentCategory { get; }

        public PieListViewModel(IEnumerable<Pie> pies, string? cuurentCategory)
        {
            Pies = pies;
            CuurentCategory = cuurentCategory;
        }


    }
}

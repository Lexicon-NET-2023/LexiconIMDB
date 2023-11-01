using LexiconIMDB.Data;
using LexiconIMDB.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LexiconIMDB.ViewComponents
{
    //[ViewComponent]
    public class StarViewComponent : ViewComponent
    {
        //private readonly LexiconIMDBContext context;

        //public StarViewComponent(LexiconIMDBContext context)
        //{
        //    this.context = context;
        //}

        public IViewComponentResult Invoke(float rating)
        {
            var doubleRating = (int)Math.Round(rating * 2);

            var model = new StarViewModel
            {
                Stars = doubleRating / 2,
                IsHalfStar = doubleRating % 2 == 1
            };

            return View(model);
        }
    }
}

using InnspireWebsite.Data.Index;

namespace InnspireWebsite.Services
{
    public class SliderService
    {
        private IEnumerable<SliderItem> demoItems
        {
            get
            {
                yield return new SliderItem("WELCHOME TO THE PAGE", "This is title 1", "Substitle 1", "img/photo-slide-1-jpg");
                yield return new SliderItem("WELCHOME TO THE PAGE", "This is title 2", "Substitle 2", "img/photo-slide-2-jpg");
                yield return new SliderItem("WELCHOME TO THE PAGE", "This is title 3", "Substitle 3", "img/photo-slide-3-jpg");
            }
        }

        public IEnumerable<SliderItem> GetSlides()
        {
            return demoItems;
        }
    }
}

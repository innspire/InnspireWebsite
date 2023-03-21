namespace InnspireWebsite.Data.Index
{
    public class SliderItem
    {
        public string PreHeader { get; set; } = "Lorem Ipsum Dolor";

        public string Title { get; set; } = "Title";

        public string Subtitle { get; set; } = "Subtitle";

        public string ImageSource { get; set; } = "img/photo-slide-1-jpg";

        public SliderItem(string preHeader, string title, string subtitle, string imageSource)
        {
            this.PreHeader = preHeader;
            this.Title = title;
            this.Subtitle = subtitle;
            this.ImageSource = imageSource;
        }
    }
}

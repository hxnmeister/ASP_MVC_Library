namespace ASP_MVC_Library.Models
{
    public class QuoteResponseModel
    {
        public int count { get; set; }
        public int totalCount { get; set; }
        public int page { get; set; }
        public int totalPages { get; set; }
        public int lastItemIndex { get; set; }
        public QuoteModel[] results { get; set; }
    }
}

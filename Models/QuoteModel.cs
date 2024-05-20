namespace ASP_MVC_Library.Models
{
    public class QuoteModel
    {
        public string _id { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public string[] tags { get; set; }
        public string authorSlug { get; set; }
        public int length { get; set; }
    }
}

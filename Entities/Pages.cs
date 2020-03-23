namespace Entities.Entities
{
    public class Pages
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        public string PageUrl { get; set; }
        public string PageDescription { get; set; }
        public string PageMetaTage { get; set; }
        public string PageKeyWord { get; set; }
        public bool? isActive { get; set; }
    }
}

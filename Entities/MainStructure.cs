using System;

namespace Entities.Entities
{
    public class MainStructure
    {
        public int MainStructureID { get; set; }
        public int? HeaderID { get; set; }
        public int? SubHeaderID { get; set; }
        public int? FooterID { get; set; }
        public int? TotalPages { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? Active { get; set; }
    }
}

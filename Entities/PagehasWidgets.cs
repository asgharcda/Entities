using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
   public class PagehasWidgets
    {
        public int PageHasWidgetID { get; set; }
        public int? WidgetID { get; set; }
        public int? PageID { get; set; }
        public int? MainStructureID { get; set; }
        public int? isActive { get; set; }
        public DateTime? DateTime { get; set; }

    }
}

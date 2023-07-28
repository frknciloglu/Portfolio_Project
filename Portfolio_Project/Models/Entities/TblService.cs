using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblService
    {
        public int ServiceID { get; set; }

        public string ServiceTitle { get; set; }

        public string ServiceIcon { get; set; }

        public string ServiceNumber { get; set; }

        public string ServiceContent { get; set; }
    }
}
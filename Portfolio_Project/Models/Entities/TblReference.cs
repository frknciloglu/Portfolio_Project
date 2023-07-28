using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblReference
    {
        public int ReferenceID { get; set; }

        public string ReferenceName { get; set; }

        public string ReferenceNo { get; set; }

        public string ReferenceMail { get; set; }
    }
}
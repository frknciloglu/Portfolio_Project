using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblVideo
    {
        public int VideoID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string VideoFrame { get; set; }
    }
}
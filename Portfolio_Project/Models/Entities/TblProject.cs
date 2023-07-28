using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblProject
    {
        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

        public string ProjectDescription { get; set; }
    }
}
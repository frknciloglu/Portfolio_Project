using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblFeature
    {
        public int FeatureID { get; set; }

        public string FeatureTitle { get; set; }

        public string FeatureDescription { get; set; }

        public string FeatureImageUrl { get; set; }
    }
}
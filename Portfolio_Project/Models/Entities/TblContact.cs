using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblContact
    {
        public int ContactID { get; set; }

        public string NameSurname { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

    }
}
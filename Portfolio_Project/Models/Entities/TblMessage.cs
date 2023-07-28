using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblMessage
    {
        public int MessageID { get; set; }

        public string NameSurname { get; set; }

        public string SenderMail { get; set; }

        public string MessageSubject { get; set; }

        public string Content { get; set; }
    }
}
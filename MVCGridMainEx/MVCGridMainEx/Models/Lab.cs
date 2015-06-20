using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGridMainEx.Models
{
    public class Lab
    {
        public string LicenseNo { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string Status { get; set; }
    }
}
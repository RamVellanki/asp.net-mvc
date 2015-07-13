using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KOMVCApp.Models
{
    public class ProductModel
    {
        [DisplayName("Product Id")]
        public int ProdId { get; set; }

        [DisplayName("Product Name")]
        public string ProdName { get; set; }

        [DisplayName("Product Owner")]
        public string ProdOwner { get; set; }

        [DisplayName("Number of Versions")]
        public int NumOfVersions { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGridMainEx.Models
{
    public class LabRepository
    {
        public List<Lab> labs;
        public LabRepository()
        {
            labs = new List<Lab>();
            
            Lab x = new Lab();
            x.LicenseNo = "AZ1001";
            x.Owner = "Johnny Ridge";
            x.ReceivedDate = new DateTime(2015, 5, 30);
            x.Status = "Active";
            x.Title = "Avalanche Labs";
            labs.Add(x);

            x = new Lab();
            x.LicenseNo = "AZ1002";
            x.Owner = "Johnny Ridge";
            x.ReceivedDate = new DateTime(2015, 5, 30);
            x.Status = "Active";
            x.Title = "Avalanche Labs 2";

            labs.Add(x);

            x = new Lab();
            x.LicenseNo = "AZ1003";
            x.Owner = "Johnny Ridge";
            x.ReceivedDate = new DateTime(2015, 5, 30);
            x.Status = "Active";
            x.Title = "Avalanche Labs 3";
            labs.Add(x);

            x = new Lab();
            x.LicenseNo = "AZ1004";
            x.Owner = "Johnny Ridge";
            x.ReceivedDate = new DateTime(2015, 5, 30);
            x.Status = "Active";
            x.Title = "Avalanche Labs 4";
            labs.Add(x);
        }

        public List<Lab> getAll()
        {
            return labs;
        }
    }
}
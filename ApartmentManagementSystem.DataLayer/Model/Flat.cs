using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataLayer.Model
{
    public class Flat
    {
        public int FlatID { get; set; }
        public int FlatNo { get; set; }
        public string FlatOwner { get; set; }
        public string FlatOwnerName { get; set; }
        public string FlatOwnerLastName { get; set; }
        public string FlatTenantName { get; set; }
        public string FlatTenantLastName { get; set; }
        public double PaidMoney { get; set; }
        public DateTime LastPaymentDate { get; set; }
    }
}

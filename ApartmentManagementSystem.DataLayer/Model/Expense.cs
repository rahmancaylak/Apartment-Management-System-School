using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.DataLayer.Model
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public int Due { get; set; }
        public int HotWater { get; set; }
        public int ColdWater { get; set; }
        public int PoolMaintenance { get; set; }
        public int Gym { get; set; }
        public int SecurityExpense { get; set; }
        public int Garden { get; set; }
        public int InterestMaturityStart { get; set; }
        public double InterestRate { get; set; }
    }
}

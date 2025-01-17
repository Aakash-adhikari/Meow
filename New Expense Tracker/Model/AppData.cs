using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Expense_Tracker.Model;
using New_Expense_Tracker.Models;

namespace New_Expense_Tracker.Components.Model
{
    public class AppData
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Transactions> Transactions { get; set; } = new List<Transactions>();
        public List<Debts> Debts { get; set; } = new List<Debts>();
    }
}
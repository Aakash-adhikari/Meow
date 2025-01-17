namespace New_Expense_Tracker.Models
{
    public class Debts
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Link debt to a user
        public decimal Amount { get; set; } // Total debt amount
        public decimal PaidAmount { get; set; } // Amount paid towards debt
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; } // New field: Due date for the debt
        public string Source { get; set; } // New field: Source of the debt
        public string Description { get; set; } // Description of the debt

        // Helper property to calculate remaining debt
        public decimal RemainingDebt => Amount - PaidAmount;

        // Helper property for debt status
        public string Status => RemainingDebt > 0 ? "Pending" : "Cleared";
    }
}
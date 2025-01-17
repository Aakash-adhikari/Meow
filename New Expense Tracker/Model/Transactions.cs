namespace New_Expense_Tracker.Model
{
    public class Transactions
    {
        public int Id { get; set; }
        public string Title { get; set; } // Title of the transaction
        public decimal Debit { get; set; } // Cash out
        public decimal Credit { get; set; } // Cash in
        public string Type { get; set; } // "Debit" or "Credit"
        public DateTime Date { get; set; }
        public string Notes { get; set; } // Notes (renamed from Description)
        public string Tags { get; set; } // Tags for categorization
    }
}

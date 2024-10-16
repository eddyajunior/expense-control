namespace ExpenseControl.Application.Expenses.Requests
{
    public class AddNewExpenseRequest
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}

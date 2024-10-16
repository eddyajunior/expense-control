namespace ExpenseControl.Domain.Expense
{
    public class ExpenseEntity
    {
        public ExpenseEntity(string description, DateTime date, decimal amount)
        {
            Description = description;
            Date = date;
            Amount = amount;
        }

        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }
    }
}

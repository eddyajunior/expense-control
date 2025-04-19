namespace ExpenseControl.API.Features.Expenses.CreateExpense
{
    public class CreateExpenseRequest
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Parcela { get; set; }
        public decimal Valor { get; set; }
        public string UltimosNumerosCartao { get; set; }
        public string BandeiraCartao { get; set; }
    }
}

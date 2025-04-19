namespace ExpenseControl.API.Bases
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public Exception Exception { get; set; }
    }
}

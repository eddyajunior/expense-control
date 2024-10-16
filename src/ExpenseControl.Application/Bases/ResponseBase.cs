namespace ExpenseControl.Application.Bases
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public Exception Exception { get; set; }
        public string Message { get; set; }        
    }
}

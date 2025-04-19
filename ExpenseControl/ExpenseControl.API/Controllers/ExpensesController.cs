using ExpenseControl.API.Features.Expenses.CreateExpense;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseControl.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        /// <summary>
        /// Create a new expense.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] CreateExpenseRequest request)
        {
            var response = new CreateExpenseResponse
            {
                Success = true,
                Data = 1
            };

            return Ok(response);
        }
    }
}

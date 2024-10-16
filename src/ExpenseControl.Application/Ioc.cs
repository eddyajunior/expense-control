using ExpenseControl.Application.Expenses.AppServices;
using ExpenseControl.Application.Expenses.Interfaces;
using ExpenseControl.Domain.Expense;
using ExpenseControl.Domain.Expense.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseControl.Application
{
    public static class Ioc
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IExpenseAppService, ExpenseAppService>();
            services.AddScoped<IExpenseService, ExpenseService>();
        }
    }
}

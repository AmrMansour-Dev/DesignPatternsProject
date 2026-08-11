using DesignPatternsProject.ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.ChainOfResponsibility
{
    internal class Director : IExpenseHandler
    {
        private IExpenseHandler _handler;
        public void setNext(IExpenseHandler expenseHandler)
        {
            _handler = expenseHandler;
        }

        public void Handle(ExpenseRequest expenseRequest)
        {
            if (expenseRequest.Amount <= 5000)
            {
                Console.WriteLine($"Manager Approved the Amount {expenseRequest.Amount} Successfully");
            }
            else
            {
                Console.WriteLine("This Expense Amount is rejected !");
            }
        }
    }
}

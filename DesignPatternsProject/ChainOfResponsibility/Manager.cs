using DesignPatternsProject.ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.ChainOfResponsibility
{
    internal class Manager : IExpenseHandler
    {
        private IExpenseHandler _handler;
        public void setNext(IExpenseHandler expenseHandler)
        {
            _handler = expenseHandler;
        }

        public void Handle(ExpenseRequest expenseRequest)
        {
            if(expenseRequest.Amount <= 1000)
            {
                Console.WriteLine($"Manager Approved the Amount {expenseRequest.Amount} Successfully");
            }
            else
            {
                _handler.Handle(expenseRequest);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.ChainOfResponsibility.Interfaces
{
    internal interface IExpenseHandler
    {
        void setNext(IExpenseHandler expenseHandler);
        void Handle(ExpenseRequest expenseRequest);
    }
}

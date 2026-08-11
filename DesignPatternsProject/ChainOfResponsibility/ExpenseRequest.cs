using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.ChainOfResponsibility
{
    internal class ExpenseRequest
    {
        public string EmployeeName { get;  private set; }
        public int Amount { get; private set; }

        public ExpenseRequest(string EmployeeName, int Amount)
        {
            this.EmployeeName = EmployeeName;
            this.Amount = Amount;
        }
    }
}

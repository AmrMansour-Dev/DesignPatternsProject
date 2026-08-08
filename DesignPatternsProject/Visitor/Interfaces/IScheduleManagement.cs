using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Visitor.Interfaces
{
    internal interface IScheduleManagement
    {
        void GenerateReport();
        void CalculateOverTime();
        void Accept(IScheduleManagementVisitor scheduleManagementVisitor);
    }
}

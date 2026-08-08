using DesignPatternsProject.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Visitor
{
    internal class RemoteWorkScheduleManagement : IScheduleManagement
    {
        public void CalculateOverTime()
        {
            Console.WriteLine("Calculating OverTime for Remote Work Shift");
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generating Report for Remote Work Shift");

        }
    }
}

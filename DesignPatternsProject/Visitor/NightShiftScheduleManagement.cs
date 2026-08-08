using DesignPatternsProject.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Visitor
{
    internal class NightShiftScheduleManagement : IScheduleManagement
    {
        public void CalculateOverTime()
        {
            Console.WriteLine("Calculating OverTime for Night Shift");
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generating Report for Night Shift");

        }
    }
}

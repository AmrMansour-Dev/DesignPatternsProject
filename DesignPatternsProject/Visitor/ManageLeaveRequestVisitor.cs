using DesignPatternsProject.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Visitor
{
    internal class ManageLeaveRequestVisitor : IScheduleManagementVisitor
    {
        public void Visit(DayShiftScheduleManagement dayShiftScheduleManagement)
        {
            Console.WriteLine("Managing Day Shift Leaves");
        }

        public void Visit(NightShiftScheduleManagement nightShiftScheduleManagement)
        {
            Console.WriteLine("Managing Night Shift Leaves");
        }

        public void Visit(RemoteWorkScheduleManagement remoteworkShiftScheduleManagement)
        {
            Console.WriteLine("Managing Remote Work Shift Leaves");
        }
    }
}

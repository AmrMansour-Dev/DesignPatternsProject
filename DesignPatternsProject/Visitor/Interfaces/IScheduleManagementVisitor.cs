using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Visitor.Interfaces
{
    internal interface IScheduleManagementVisitor
    {
        void Visit(DayShiftScheduleManagement dayShiftScheduleManagement);
        void Visit(NightShiftScheduleManagement nightShiftScheduleManagement);
        void Visit(RemoteWorkScheduleManagement remoteworkShiftScheduleManagement);
    }
}

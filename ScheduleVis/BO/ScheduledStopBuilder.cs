using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleVis.BO
{
    public class ScheduledStopBuilder: IImportedItemFactory
    {
        public IImportedItem Create(string line)
        {
            ScheduledStop result = new ScheduledStop();
            result.PopulateFromLine(line);
            return result;
        }

        public string GetFieldCode()
        {
            return "LI";
        }
    }
}

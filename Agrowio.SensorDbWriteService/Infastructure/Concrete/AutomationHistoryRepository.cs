using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Entities.Concrete.HistoryConcrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class AutomationHistoryRepository  : DbService<AutomationHistory>, IAutomationHistoryRepository
    {
        public AutomationHistoryRepository( ):base("AutomationHistory" )
        {
           
        }
    }
}

using Agrowio.SensorDbWriteService.Entities.Concrete.HistoryConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Abstract
{
    public interface IAutomationHistoryRepository: IDbService<AutomationHistory> 
    {
    }
}


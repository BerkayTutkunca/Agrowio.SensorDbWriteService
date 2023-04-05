using Agrowio.SensorDbWriteService.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Abstract
{
    public interface IFlowMeterRepository:IDbService<FlowMeter>
    {
    }
}

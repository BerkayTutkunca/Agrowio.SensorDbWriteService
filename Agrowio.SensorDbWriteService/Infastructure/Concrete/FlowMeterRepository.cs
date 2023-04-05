using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class FlowMeterRepository : DbService<FlowMeter>, IFlowMeterRepository
    {
        public FlowMeterRepository() : base("FlowMeter")
        {

        }
    }
}

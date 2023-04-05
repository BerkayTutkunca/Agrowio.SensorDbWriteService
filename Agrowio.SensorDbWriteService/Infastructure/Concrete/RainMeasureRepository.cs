using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class RainMeasureRepository : DbService<RainMeasaure>, IRainMeasureRepository
    {
        public RainMeasureRepository() : base("RainMeasure")
        {

        }
    }
}

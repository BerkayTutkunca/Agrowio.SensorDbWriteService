using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class EcMeasureRepository : DbService<EcMeasure>, IEcMeasureRepository
    {
        public EcMeasureRepository() : base("EcMeasure")
        {

        }
    }
}

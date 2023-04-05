using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class PressureMeasureRepository: DbService<PressureMeasure>, IPressureMeasureRepository
    {
        public PressureMeasureRepository() : base("PressureMeasure")
        {

        }

    }
}

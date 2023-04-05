using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class PhMeasureRepository : DbService<PhMeasure>, IPhMeasureRepository
    {
        public PhMeasureRepository() : base("PhMeasure")
        {

        }
    }
}

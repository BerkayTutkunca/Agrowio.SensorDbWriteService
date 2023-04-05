using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class TankLevelRepository: DbService<TankLevel>, ITankLevelRepository
    {
        public TankLevelRepository() : base("TankLevel")
        {

        }
    }
}

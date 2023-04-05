using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class SolarRadiationRepository : DbService<SolarRadiation>, ISolarRadiationRepository
    {
        public SolarRadiationRepository() : base("SolarRadiation")
        {

        }
    }
}

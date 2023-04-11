

using Agrowio.Common.MongoDbService.Infrastructure.Abstractions;
using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Concrete;

namespace Agrowio.Common.MongoDbService.Infrastructure.Repositories
{
    public class OutTemperatureRepository : DbService<OutTemperature>, IOutTemperatureRepository
    {
        public OutTemperatureRepository() : base("OutTemperature")
        {

        }

    }
}
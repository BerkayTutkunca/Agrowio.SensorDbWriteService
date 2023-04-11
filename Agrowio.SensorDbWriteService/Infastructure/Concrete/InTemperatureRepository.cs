
using Agrowio.Common.MongoDbService.Infrastructure.Abstractions;
using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Concrete;

namespace Agrowio.Common.MongoDbService.Infrastructure.Repositories
{
    public class InTemperatureRepository : DbService<InTemperature>, IInTemperatureRepository
    {
        public InTemperatureRepository() : base("InTemperature")
        {

        }

    }
}
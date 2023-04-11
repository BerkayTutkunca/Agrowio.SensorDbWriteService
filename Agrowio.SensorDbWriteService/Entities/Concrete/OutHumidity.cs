
using Agrowio.SensorDbWriteService.Entities.BaseEntities;
using MongoDB.Bson.Serialization.Attributes;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    [BsonDiscriminator("OutHumidity")]
    [Serializable]
    public class OutHumidity : BaseSensor
    {

    }
}

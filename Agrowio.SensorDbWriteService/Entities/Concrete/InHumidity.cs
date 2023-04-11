using Agrowio.SensorDbWriteService.Entities.BaseEntities;
using MongoDB.Bson.Serialization.Attributes;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    [Serializable]
    [BsonDiscriminator("InHumidity")]
    public class InHumidity : BaseSensor
    {

    }
}

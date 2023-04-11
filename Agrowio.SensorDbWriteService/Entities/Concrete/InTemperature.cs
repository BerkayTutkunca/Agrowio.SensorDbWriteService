using Agrowio.SensorDbWriteService.Entities.BaseEntities;
using MongoDB.Bson.Serialization.Attributes;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    [BsonDiscriminator("InTemperature")]
    [Serializable]
    public class InTemperature : BaseSensor
    {

    }

    //public class TemperatureMetadata : BaseMeta
    //{
    //    [BsonElement("metadata")]
    //    public string PoliField { get; set; }
    //}

}

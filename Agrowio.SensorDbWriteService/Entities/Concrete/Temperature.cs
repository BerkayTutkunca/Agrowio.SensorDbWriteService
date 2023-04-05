using Agrowio.SensorDbWriteService.Entities.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    [BsonDiscriminator("temperature")]
    [Serializable]
    public class Temperature : BaseSensor
    {

    }

    //public class TemperatureMetadata : BaseMeta
    //{
    //    [BsonElement("metadata")]
    //    public string PoliField { get; set; }
    //}
}

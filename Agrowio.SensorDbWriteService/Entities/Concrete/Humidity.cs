using Agrowio.SensorDbWriteService.Entities.Abstract;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    //[BsonDiscriminator("humidity")]
    [Serializable]
    public class Humidity : BaseSensor
    {
        
    }
    public class HumidityMetadata : BaseMeta
    {
        //[BsonElement("metadata")]
        public string PoliField { get; set; }
    }
}

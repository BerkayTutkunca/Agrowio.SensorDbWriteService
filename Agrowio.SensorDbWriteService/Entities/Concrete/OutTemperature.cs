using Agrowio.SensorDbWriteService.Entities.BaseEntities;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    [BsonDiscriminator("OutTemperature")]
    [Serializable]
    public class OutTemperature : BaseSensor
    {
    }
}

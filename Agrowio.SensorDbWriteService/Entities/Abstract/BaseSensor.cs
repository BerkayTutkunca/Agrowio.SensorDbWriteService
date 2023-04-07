using Agrowio.Common.Persistence.Entities.BaseEntities;
using Agrowio.SensorDbWriteService.Entities.Concrete;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Abstract
{
    //[BsonDiscriminator(RootClass = true)]
    public abstract class BaseSensor : BaseCollection
    {
    [BsonElement("timestamp")]
    public DateTime Timestamp { get; set; }

    [BsonElement("value")]
    public int Value { get; set; }

    [BsonElement("metadata")]
    public BaseMeta Metadata { get; set; }
}
}

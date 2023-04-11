using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.BaseEntities
{
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

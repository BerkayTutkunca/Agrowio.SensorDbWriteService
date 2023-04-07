using Agrowio.Common.Persistence.Entities.BaseEntities;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Abstract
{
    [Serializable]
    public abstract class BaseHistory : BaseCollection
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("value")]
        public int Value { get; set; }
        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}

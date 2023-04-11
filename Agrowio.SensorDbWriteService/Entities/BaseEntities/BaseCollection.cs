using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Agrowio.SensorDbWriteService.Entities.BaseEntities
{
    public abstract class BaseCollection
    {

        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("InputId")]
        public Guid InputId { get; set; }


    }
}

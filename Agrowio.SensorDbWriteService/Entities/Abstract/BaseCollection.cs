using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Agrowio.Common.Persistence.Entities.BaseEntities
{
    public abstract class BaseCollection
    {

        [BsonId]
        public ObjectId Id { get; set; }

    }
}

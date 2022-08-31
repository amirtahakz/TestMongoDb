using MongoDB.Bson.Serialization.Attributes;

namespace TestMongoDb.Entities
{
    public class BaseEntity
    {
        [BsonId]
        public Guid Id { get; set; }
    }
}

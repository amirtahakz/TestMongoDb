using MongoDB.Bson.Serialization.Attributes;

namespace TestMongoDb.Entities
{
    public class User : BaseEntity
    {

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("family")]
        public string Family { get; set; }

        [BsonIgnore]
        [BsonElement("fullName")]
        public string FullName =>$"{Name} {Family}";
    }
}

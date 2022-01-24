using MongoDB.Bson.Serialization.Attributes;

namespace Clean_arch.Query.Shared
{
    public class BaseReadModel
    {
        [BsonId]
        public long Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
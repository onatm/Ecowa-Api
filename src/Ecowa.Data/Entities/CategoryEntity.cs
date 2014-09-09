using Autofuzz.MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ecowa.Data
{
    [Collection("categories")]
    public class CategoryEntity : Entity<ObjectId>
    {
        [BsonRequired]
        public string Name { get; set; }
    }
}

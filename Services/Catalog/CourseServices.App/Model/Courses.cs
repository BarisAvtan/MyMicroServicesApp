using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CourseServices.Catalog.Model
{
    public class Courses
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]//Id string olduğu için BsonRepresentation ile id yi string olarak verecek,id string gönderildiğinde ise bunu object id'e dönüştürecek
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }

        public string UserId { get; set; }

        public string Picture { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }

        public Feature Feature { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonIgnore]
        public Category Category { get; set; } //Mongo db de yer almacak
    }
}

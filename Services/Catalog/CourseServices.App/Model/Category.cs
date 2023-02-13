using CourseServices.Catalog.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CourseServices.Catalog.Model
{
    public class Category
    {
      
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]//Id string olduğu için BsonRepresentation ile id yi string olarak verecek,id string gönderildiğinde ise bunu object id'e dönüştürecek
        public string Id { get; set; }
        
        public string Name { get; set; }
    }
}

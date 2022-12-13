using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GratitudeAppLibrary.Models
{
    public class GratitudeModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? UserId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public List<string> Line { get; set; } = new List<string>();
    }
}

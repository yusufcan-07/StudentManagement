using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace StudentManagement.Models;
[BsonIgnoreExtraElements]//to ignore extra fields in database
public class Student
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)] //convert mongo data type to dotnet data type vice versa
    public string Id { get; set; } = String.Empty;
    
    [BsonElement("name")]//because of casing we need to map the database and code
    public string Name { get; set; } = String.Empty;
    
    [BsonElement("graduated")]
    public bool  IsGraduated { get; set; }
    
    [BsonElement("courses")]
    public string[]?  Courses { get; set; }
    
    [BsonElement("gender")]
    public string Gender { get; set; } = String.Empty;
    
    [BsonElement("age")]
    public int Age { get; set; }
    
    
}
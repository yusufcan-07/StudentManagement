using StudentManagement.Models;
using MongoDB.Driver;
namespace StudentManagement.Services;

public class StudentService : IStudentService
{
    private readonly IMongoCollection<Student> _students;

    public StudentService(IStudentStoreDatabaseSettings settings, IMongoClient mongoClient)
    {
       var db= mongoClient.GetDatabase(settings.DatabaseName);
       _students = db.GetCollection<Student>(settings.StudentCoursesCollectionName);

    }
    public List<Student> Get()
    {
        return _students.Find(student => true).ToList();
    }

    public Student Get(string id)
    {
        return _students.Find(student => student.Id == id ).FirstOrDefault();
    }

    public Student Create(Student student)
    {
        _students.InsertOne(student);
        return student;
    }

    public void Update(string id, Student student)
    {
        _students.ReplaceOne(student => student.Id == id, student );
    }

    public void Delete(string id)
    {
         _students.DeleteOne(student => student.Id == id );
    }
}
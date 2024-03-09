namespace StudentManagement.Models;

public class StudentStoreDatabaseSettings:IStudentStoreDatabaseSettings
{
    //with interface, it will be used to read and store data given db settings
    public string StudentCoursesCollectionName { get; set; } = String.Empty;
    public string ConnectionString { get; set; } = String.Empty;
    public string DatabaseName { get; set; } = String.Empty;
}
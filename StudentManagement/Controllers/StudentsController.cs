using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }
    //Get: api/<StudentsController> 
    [HttpGet]
    public ActionResult<List<Student>> Get()
    {
        return _studentService.Get();
    }
    //Get: api/<StudentsController>5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }
    //Post: api/<StudentsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }
    //Put: api/<StudentsController>
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

}
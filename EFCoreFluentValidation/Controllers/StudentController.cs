using EFCoreFluentValidation.Models.DTOs;
using EFCoreFluentValidation.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreFluentValidation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    FluentValidationContext _context;
    public StudentController()
    {
        _context = new FluentValidationContext();
    }
    [HttpPost]
    public IActionResult AddStudent(CreateStudentRequestDto model)
    {
        Student student = new Student();
        student.Name = model.Name;
        student.Email = model.Email;
        student.Surname = model.Surname;
        student.Phone = model.Phone;
        student.BirthDate = model.BirthDate;
        _context.Students.Add(student);
        _context.SaveChanges();
        return Ok ();
    }
}

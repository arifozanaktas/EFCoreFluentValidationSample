using EFCoreFluentValidation.Models.DTOs;
using EFCoreFluentValidation.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreFluentValidation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UniversityController : ControllerBase
{
    FluentValidationContext _context;
    public UniversityController()
    {
        _context = new FluentValidationContext();
    }

    [HttpPost]
    public IActionResult AddUniversity(AddUniversityRequestDto request)
    {
        University university = new University();
        university.City = request.City;
        university.Name = request.Name;
        _context.Universities.Add(university);
        _context.SaveChanges();
        return Ok(request);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateUniversity(int id, UpdateUniversityRequestDto request)
    {
        University university = _context.Universities.FirstOrDefault(x =>  x.Id == id);
        if (university == null)
        {
            return BadRequest("Not Found");
        }
        university.Name = request.Name;
        university.City = request.City;
        return Ok(request);
    }

}

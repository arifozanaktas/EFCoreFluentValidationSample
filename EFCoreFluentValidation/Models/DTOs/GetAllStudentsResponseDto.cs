using EFCoreFluentValidation.Models.ORM;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreFluentValidation.Models.DTOs;

public class GetAllStudentsResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }

    public string UniversityName { get; set; }
}

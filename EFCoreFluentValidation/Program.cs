
using EFCoreFluentValidation.Models.DTOs;
using EFCoreFluentValidation.Models.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace EFCoreFluentValidation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddFluentValidationAutoValidation()
        .AddFluentValidationClientsideAdapters();

        builder.Services.AddScoped<IValidator<CreateStudentRequestDto>, CreateStudentRequestDtoValidator>();
        builder.Services.AddScoped<IValidator<UpdateStudentRequestDto>, UpdateStudentRequestDtoValidator>();
        builder.Services.AddScoped<IValidator<AddUniversityRequestDto>, AddUniversityRequestDtoValidator>();
        builder.Services.AddScoped<IValidator<UpdateUniversityRequestDto>, UpdateUniversityRequestDtoValidator>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}

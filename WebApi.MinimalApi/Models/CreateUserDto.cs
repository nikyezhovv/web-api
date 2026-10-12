using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace WebApi.MinimalApi.Models;

public class CreateUserDto
{
    [Required]
    public string Login { get; set; }

    [DefaultValue("John")]
    public string FirstName { get; set; }

    [DefaultValue("Doe")]
    public string LastName { get; set; }
}
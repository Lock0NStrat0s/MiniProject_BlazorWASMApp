using System.ComponentModel.DataAnnotations;

namespace MiniProject_BlazorWASM.Models;

public class PersonModel
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
}

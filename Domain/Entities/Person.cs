using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Domain.Enums;

namespace Domain.Entities;

[Table("Persons")]
public class Person : Entity
{
    [Required]
    public PersonQualification Qualification { get; set; }
    
    [Required]
    public PersonType Type { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(14)]
    public int Document { get; set; }
    
    [MaxLength(100)]
    public string FantasyName { get; set; }
    
    [Required]
    [MaxLength(500)]
    public string Address { get; set; }
    
    public bool IsValid(out List<string> errorMessages)
    {
        errorMessages = new List<string>();

        if (Type == PersonType.LegalPerson)
        {
            if (Document.ToString().Length != 14)
            {
                errorMessages.Add("Legal person document length must be 14 characters.");
            }
        }
        else
        {
            if (Document.ToString().Length != 11)
            {
                errorMessages.Add("Natural person document length must be 11 characters.");
            }
        }

        if (string.IsNullOrEmpty(Name) || !Name.All(c => char.IsLetter(c) || c == ' '))
        {
            errorMessages.Add("Name should only contain letters and spaces.");
        }

        return errorMessages.Count == 0;
    }
}
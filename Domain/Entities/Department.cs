using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities;

[Table("Departments")]
public class Department : Entity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    public Guid ResponsibleId { get; set; }
    
    [ForeignKey("ResponsibleId")]
    public Person Responsible { get; set; }
    
    public bool IsValid(out List<string> errorMessages)
    {
        errorMessages = new List<string>();

        if(string.IsNullOrEmpty(Name) || !Name.All(c => char.IsLetter(c) || c == ' '))
        {
            errorMessages.Add("Name should only contain letters and spaces.");
        }
        
        if(Responsible.Qualification != PersonQualification.Collaborator)
        {
            errorMessages.Add("Responsible must be a collaborator.");
        }

        return errorMessages.Count == 0;
    }
}
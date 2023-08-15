using System.Numerics;
using Domain.Enums;

namespace Domain.Entities;

public class Person : Entity
{
    public PersonQualification Qualification { get; set; }
    public PersonType Type { get; set; }
    public string Name { get; set; }
    public int Document { get; set; }
    public string FantasyName { get; set; }
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
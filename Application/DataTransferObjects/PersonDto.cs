
namespace Application.DataTransferObjects;

public class PersonDto
{
    
    public PersonQualificationDto Qualification { get; set; }
    public PersonTypeDto Type { get; set; }
    public string Name { get; set; }
    public int Document { get; set; }
    public string FantasyName { get; set; }
    public string Address { get; set; }}
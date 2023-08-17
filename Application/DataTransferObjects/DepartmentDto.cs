namespace Application.DataTransferObjects;

public class DepartmentDto
{
    public string Name { get; set; }
    public Guid ResponsibleId { get; set; }
    public PersonDto Responsible { get; set; }
}
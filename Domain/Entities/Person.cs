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
}
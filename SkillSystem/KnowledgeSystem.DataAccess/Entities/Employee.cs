namespace KnowledgeSystem.DataAccess.Entities;

public class Employee
{
    public long EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<Knowledge> Knowledge { get; set; }
}

namespace KnowledgeSystem.DataAccess.Entities;

public class Knowledge
{
    public long KnowledgeId { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public KnowledgeLevel Level { get; set; }
    public string Description { get; set; }

    public long EmployeeId { get; set; }
    public Employee Employee { get; set; }
}

public enum KnowledgeLevel
{
    Elementary,
    PreIntermediate,
    Intermediate,
    UpperIntermediate,
    Advanced,
    Expert,
    Master
}
namespace KnowledgeSystem.Bll.Dtos.KnowledgeDto;

public class KnowledgeGetDto
{
    public long KnowledgeId { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public KnowledgeLevelDto Level { get; set; }
    public string Description { get; set; }

    public long EmployeeId { get; set; }
}

public enum KnowledgeLevelDto
{
    Elementary,
    PreIntermediate,
    Intermediate,
    UpperIntermediate,
    Advanced,
    Expert,
    Master
}

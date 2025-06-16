using KnowledgeSystem.DataAccess.Entities;

namespace KnowledgeSystem.Bll.Dtos.KnowledgeDto;

public class KnowledgeCreateDto
{
    public string Type { get; set; }
    public string Name { get; set; }
    public KnowledgeLevel Level { get; set; }
    public string Description { get; set; }

    public long EmployeeId { get; set; }
}

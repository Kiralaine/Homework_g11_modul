using KnowledgeSystem.Bll.Dtos.KnowledgeDto;

namespace KnowledgeSystem.Bll.Dtos.EmployeeDto;

public class EmployeeGetDto
{
    public long EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<KnowledgeGetDto> KnowledgeDtos { get; set; }
}

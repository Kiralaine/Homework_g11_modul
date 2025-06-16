using KnowledgeSystem.DataAccess.Entities;

namespace KnowledgeSystem.Repository.Repositories;

public interface IEmployeeRepository
{
    Task<long> InsertAsync(Employee employee);
    Task<ICollection<Employee>> SelectAllAsync();
}
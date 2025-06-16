using Microsoft.EntityFrameworkCore;
using KnowledgeSystem.DataAccess;
using KnowledgeSystem.DataAccess.Entities;

namespace KnowledgeSystem.Repository.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly MainContext MainContext;

    public EmployeeRepository(MainContext mainContext)
    {
        MainContext = mainContext;
    }

    public async Task<long> InsertAsync(Employee employee)
    {
        await MainContext.Employees.AddAsync(employee);
        await MainContext.SaveChangesAsync();
        return employee.EmployeeId;
    }

    public async Task<ICollection<Employee>> SelectAllAsync()
    {
        var employees = await MainContext.Employees.ToListAsync();
        return employees;
    }
}

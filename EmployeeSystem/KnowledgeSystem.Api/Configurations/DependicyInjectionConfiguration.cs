using KnowledgeSystem.Bll.Services;
using KnowledgeSystem.Repository.Repositories;

namespace KnowledgeSystem.Api.Configurations;

public static class DependicyInjectionConfiguration
{
    public static void ConfigureDI(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();


    }
}

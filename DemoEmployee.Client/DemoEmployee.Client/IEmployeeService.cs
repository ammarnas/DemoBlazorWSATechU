using DemoEmployee.Core;

namespace DemoEmployee.Client
{
    public interface IEmployeeService
    {
        Task<HttpResponseMessage> CreateEmployeeAsync(Employee employee);
        Task<HttpResponseMessage> DeleteEmployeeAsync(int id);
        Task<List<Employee>?> GetAllAsync();
        Task<Employee?> GetEmployeeByIdAsync(int id);
        Task<List<Employee>?> SearchEmployeesAsync(string query);
        Task<HttpResponseMessage> UpdateEmployeeAsync(int id, Employee employee);
    }
}
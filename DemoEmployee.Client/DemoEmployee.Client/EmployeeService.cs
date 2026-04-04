using DemoEmployee.Core;
using System.Net.Http.Json;

namespace DemoEmployee.Client
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Employee>?> GetAllAsync()
            => await httpClient.GetFromJsonAsync<List<Employee>>("api/employees");

        public async Task<Employee?> GetEmployeeByIdAsync(int id)
            => await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");

        public async Task<List<Employee>?> SearchEmployeesAsync(string query)
            => await httpClient.GetFromJsonAsync<List<Employee>>($"api/employees/search/{query}");

        public async Task<HttpResponseMessage> CreateEmployeeAsync(Employee employee)
            => await httpClient.PostAsJsonAsync("api/employees", employee);

        public async Task<HttpResponseMessage> UpdateEmployeeAsync(int id, Employee employee)
            => await httpClient.PutAsJsonAsync($"api/employees/{id}", employee);

        public async Task<HttpResponseMessage> DeleteEmployeeAsync(int id)
            => await httpClient.DeleteAsync($"api/employees/{id}");
    }
}

﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Employee> CreateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }

}


using Microsoft.EntityFrameworkCore;
using Realm.Data.Models;
using Realm.Data;
using Realm.Services.Interfaces;

namespace Realm.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Service Calls
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
        public async Task<bool> InsertEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Employee> GetEmployeeAsync(int Id)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return employee;
        }
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            _context.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
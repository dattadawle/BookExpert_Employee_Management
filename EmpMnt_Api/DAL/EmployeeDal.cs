
using Microsoft.EntityFrameworkCore;

public class EmployeeDal : IEmployeeDal
{
    ApplicationDbContext _context;
    public EmployeeDal(ApplicationDbContext context)
    {
        _context = context;
    }
    public async void Create(Employee employee)
    {
        if (employee != null)
        {
           await _context.Employees.AddAsync(employee);
            _context.SaveChanges();
            
        }
    }

    public async void Delete(int id)
    {
      var emp=await _context.Employees.FindAsync(id);
         _context.Employees.Remove(emp);
        _context.SaveChanges();
    }

    public async void DeleteAll()
    {
       /* var AllEmp= _context.Employees.ToList();
        _context.Employees.RemoveRange(AllEmp);*/

        await _context.Database.ExecuteSqlRawAsync("DELETE FROM Employees");
    }

    public async  Task<List<Employee>> GetAll()
    {
        var list = await _context.Employees.ToListAsync();
        return list;
    }

    public async Task<Employee> GetById(int id)
    {
        Employee employee = await _context.Employees.FindAsync(id);
        return employee;
    }

    public async void Update(Employee employee)
    {
         _context.Employees.Attach(employee);

        _context.Entry(employee).State = EntityState.Modified; 

         await _context.SaveChangesAsync();
    }
}
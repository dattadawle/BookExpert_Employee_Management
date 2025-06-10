
public class EmployeeBal : IEmployeeBal
{
    IEmployeeDal _employeeDal;
    public EmployeeBal(IEmployeeDal employeeDal)
    {
        _employeeDal = employeeDal;
    }
    public async  void Create(Employee employee)
    {
      _employeeDal.Create(employee);
    }

    public async void Delete(int id)
    {
       _employeeDal.Delete(id);
    }

    public void DeleteAll()
    {
        _employeeDal.DeleteAll();
    }

    public async Task< List<Employee>> GetAll()
    {
     var employees=   _employeeDal.GetAll().Result;
        return employees;

    }

    public async Task< Employee> GetById(int id)
    {
       Employee emp= await _employeeDal.GetById(id);
        return emp;
    }

    public async void Update(Employee employee)
    {
       _employeeDal.Update(employee);
    }
}
public  interface IEmployeeDal
{
    Task<List<Employee>>GetAll();
    Task<Employee> GetById(int id);
    void Create(Employee employee);
    void Update(Employee employee);
    void Delete(int id);

    void DeleteAll();
}
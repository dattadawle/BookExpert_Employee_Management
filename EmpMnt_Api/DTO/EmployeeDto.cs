public class EmployeeDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Designation { get; set; }


    public DateTime DateOfJoining { get; set; } = DateTime.Today;

    public Decimal Salary { get; set; }

    public string Gender { get; set; } = "Male";

    public string State { get; set; }

    public DateTime DateOfBirth { get; set; }
    public int Age { get; set; }
}

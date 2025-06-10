using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpMnt_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeBal _employeeBal;
        public EmployeeController(IEmployeeBal employeeBal)
        {
            _employeeBal = employeeBal;
        }


        [HttpGet]
        public async Task< IActionResult> GetAll()
        {
          var employees= await _employeeBal.GetAll();
            return Ok(employees);
        }

        [HttpGet("/{id:int}")]
        public async Task< IActionResult> GetById(int id)
        {
            Employee emp= await _employeeBal.GetById(id);
            return Ok(emp); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            _employeeBal.Create(employee);
            return NoContent();
        }

        [HttpPut]
        public async Task< IActionResult> Update(Employee employee)
        {
            _employeeBal.Update(employee);
            return NoContent();
        }

        [HttpDelete("/{id:int}")]
        public async Task< IActionResult> Delete(int id)
        {
            _employeeBal.Delete(id);    
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll()
        {
            _employeeBal.DeleteAll();
            return Ok();
        }

    }
}

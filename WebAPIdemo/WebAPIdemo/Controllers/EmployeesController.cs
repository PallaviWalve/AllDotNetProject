using Microsoft.AspNetCore.Mvc;
using WebAPIdemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        static List<EmployeeModel> emplist = new List<EmployeeModel>()
         {
             new EmployeeModel {EmpId = 1, EmpName = "Pallavi", DeptNo = 10 },
             new EmployeeModel {EmpId = 2, EmpName = "Shreya", DeptNo = 20 },
             new EmployeeModel {EmpId = 3, EmpName = "Chetana", DeptNo = 20 },
             new EmployeeModel {EmpId = 4, EmpName = "Shrushti", DeptNo = 10}
         };

        [HttpGet]
        public IEnumerable<EmployeeModel> Get()
        {
            return emplist;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public EmployeeModel Get(int id)
        {
            EmployeeModel emp = emplist.Find(e => e.EmpId==id);
            return emp;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] EmployeeModel value)
        {
            emplist.Add(value);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeModel value)
        {
            EmployeeModel model = emplist.Find(e => e.EmpId == id);
            model.EmpName = value.EmpName;
            model.DeptNo = value.DeptNo;
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            EmployeeModel model = emplist.Find(e => e.EmpId == id);
            emplist.Remove(model);
        }
    }
}

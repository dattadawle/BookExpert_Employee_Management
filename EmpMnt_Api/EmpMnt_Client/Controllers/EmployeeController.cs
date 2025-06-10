using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Configuration;

namespace EmpMnt_Client.Controllers
{
    public class EmployeeController : Controller
    {
        HttpClient client;
        public EmployeeController(IConfiguration configuration)
        {
            client = new HttpClient();
            // string ApiUrl = configuration.GetValue<string>("ApiUrl");
            string ApiUrl = "https://localhost:7167/api/";
            client.BaseAddress = new Uri(ApiUrl);
        }
        public async Task <IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync("Employee");

            if (response.IsSuccessStatusCode)
            {
                string jsonResult =
                    response.Content.ReadAsStringAsync().Result;
                ViewBag.Response = jsonResult;

                // de serialization
               List <Employee> employees =
                    JsonConvert.DeserializeObject<List<Employee>>(jsonResult);
                return View(employees);
            }
            return View(null);
           
        }

    }
}

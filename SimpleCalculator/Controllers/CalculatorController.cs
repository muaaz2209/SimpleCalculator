using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace SimpleCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(string expression)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Invalid Expression");
            }
        }
    }
}

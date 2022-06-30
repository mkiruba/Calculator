using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Serivce;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {     
        private ICalculatorService _calculatorService;
        private ILogger _logger;

        public CalculatorController(ICalculatorService calculatorService, ILogger logger)
        {
            _calculatorService = calculatorService;
            _logger = logger;
        }


        [HttpGet(Name = "GetInt")]
        public int Get()
        {
            //add 2 + 3            
            _logger.LogDebug("In calculation");
            return _calculatorService.Add(2, 3);
        }
    }
}

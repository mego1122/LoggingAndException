using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoggingAndExcetion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
      


        private readonly ILoggerManager _logger;
        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }






        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    _logger.LogInfo("Here is info message from the controller.");
        //    _logger.LogDebug("Here is debug message from the controller.");
        //    _logger.LogWarn("Here is warn message from the controller.");
        //    _logger.LogError("Here is error message from the controller.");
        //    return new string[] { "value1", "value2" };
        //}





        //to make exception use this
        // throw new Exception("Exception while fetching all the students from the storage.");

        //[HttpGet]
        //public IActionResult Get()
        //{

        //    try
        //    {
        //        _logger.LogInfo("Fetching all the Students from the storage");
        //        var students = DataManager.GetAllStudents(); //simulation for the data base access
        //        _logger.LogInfo($"Returning {students.Count} students.");
        //        return Ok(students);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong: {ex}");
        //        return StatusCode(500, "Internal server error");
        //    }
        //}



        //same example without try and catch
        
      [HttpGet]
        public IActionResult Get()
        {
           
                _logger.LogInfo("Fetching all the Students from the storage");
                var students = DataManager.GetAllStudents();
                 //throw new Exception("Exception while fetching all the students from the storage.");
                 _logger.LogInfo($"Returning {students.Count} students.");
                return Ok(students);
              
           
               
            
           
          
           
        }





    }
}

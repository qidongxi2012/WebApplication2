using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    /// <summary>
    /// wgy  contrller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WgyController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching","master","master1","master2222"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public WgyController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        /// <summary>
        /// 获取token
        /// </summary>
        /// <returns>返回token</returns>
        ///<remarks>描述</remarks>
        ///<param name="id">主键</param>
        ///<response code="201">入参为NULL</response >
        ///<response code="301">异常</response >
        [HttpGet]
        public ActionResult Get(int id)
        {
            return Ok(new { token = "token" });
        }

        /// <summary>
        /// put 方法
        /// </summary>
        /// <param name="id">传入的ID 值</param>
        /// <response code="505">我赢了</response>
        /// <response code="502">我赢了1</response>
        /// <response code="501">我赢了3</response>
        /// <returns></returns>
        [HttpPut]
        public string pp (string id)
        {
            return id;
        }
    }
}

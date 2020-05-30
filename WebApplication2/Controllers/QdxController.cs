using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    /// <summary>
    /// qdx congroller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QdxController : Controller
    {
        /// <summary>
        /// get fangfa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("gettttttt")]
        public WeatherForecast get(string id)
        {
            return new WeatherForecast();
        }

        [HttpGet("ge22222")]
        public WeatherForecast getttt(string id)
        {
            return new WeatherForecast();
        }

        /// <summary>
        /// post fangfa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("putttt")]
        public WeatherForecast post(string id,WeatherForecast name)
        {
            return name;
        }

        /// <summary>
        /// delete fangfa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("deleeeeee")]
        public WeatherForecast del(string id)
        {
            return new WeatherForecast();
        }

        /// <summary>
        /// updt fangfa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("putttttt")]
        public WeatherForecast pu(string id,WeatherForecast name)
        {
            return new WeatherForecast();
        }
    }
}
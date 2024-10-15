using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PD.K8S.API.B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBController : ControllerBase
    {
        IConfiguration _configuration;

        public ApiBController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: api/<ApiBController>
        [HttpGet]
        public string Get()
        {
            var message = _configuration["api-message"];
            return message;
        }

        // GET api/<ApiBController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiBController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiBController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiBController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

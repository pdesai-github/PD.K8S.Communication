using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PD.K8S.API.A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiAController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ApiAController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: api/<ApiAController>
        [HttpGet]
        public async Task<string> Get()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(_configuration["apib-service-url"]);
                var message = _configuration["api-message"];

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return string.Concat($" {message} : {content}");
                }
                else
                {
                    return "Error";
                }
            }     

           
        }
      
    }
}

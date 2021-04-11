using Microsoft.AspNetCore.Mvc;
using BikeEShop.Domain;

namespace BikeEShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestClassController : ControllerBase
    {
        [HttpGet]
        public string GetTestClassMsg()
        {
            TestClass tc = new TestClass();
            return tc.Hello;
        } 
    }
}

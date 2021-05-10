using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeEShop.Domain;

namespace BikeEShop.API.Controllers
{
    public class UserController : Controller
    { 
        //Todo : add constructor to initiate userContext
        //create the datebase and usercontext in Data project like BikeContext
        //creat first interface and then repository for controller logic 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(User user)
        {

            return Ok();
        }


    }
}

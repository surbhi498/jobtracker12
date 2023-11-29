﻿using Microsoft.AspNetCore.Mvc;
using service;

namespace jobtrackerapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService service;
        public UserController(IUserService _userService)
        {
            service = _userService;
        }

<<<<<<< Updated upstream
        [HttpGet(Name = "GetUser")]
        [GoogleTokenValidationAttribute]
        public List<service.Models.User> Get()
=======
        // [HttpGet(Name = "GetUser")]
        // public List<service.Models.User> Get()
        // {
        //     return service.GetAll().Result;
        // }

        
        [HttpGet(Name ="jobs")]
        public List<service.Models.Job> GetUserJobs(Guid userId)
>>>>>>> Stashed changes
        {
            return service.GetUserJobs(userId).Result;
        }

    }

}

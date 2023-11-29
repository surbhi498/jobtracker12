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

        // [HttpGet(Name = "GetUser")]
        // public List<service.Models.User> Get()
        // {
        //     return service.GetAll().Result;
        // }

        
        [HttpGet(Name ="jobs")]
        public List<service.Models.Job> GetUserJobs(Guid userId)
        {
            return service.GetUserJobs(userId).Result;
        }

    }

}

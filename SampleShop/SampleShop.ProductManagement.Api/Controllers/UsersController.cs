using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleShop.ProductManagement.Api.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleShop.ProductManagement.Api.Controllers
{
    /// <summary>
    /// UsersController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// constructor
        /// </summary>
        public UsersController()
        {

        }
        /// <summary>
        /// GetUserData method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserData")]
        [Authorize(Policy = PoliciesExtensions.User)]
        public IActionResult GetUserData()
        {
            return Ok("This is a response from user method");
        }

        /// <summary>
        /// GetAdminData method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAdminData")]
        [Authorize(Policy = PoliciesExtensions.Admin)]
        public IActionResult GetAdminData()
        {
            return Ok("This is a response from Admin method");
        }
    }
}


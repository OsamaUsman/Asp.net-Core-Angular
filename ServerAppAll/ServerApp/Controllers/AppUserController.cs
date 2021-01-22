using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private UserManager<AppUser> _userManager;
        public AppUserController(UserManager<AppUser> _userManager)
        {
         this._userManager = _userManager;
        }

        [HttpPost]
        [Route("Register")]
        //api/appnuser/register

        public async Task<object> PostAppUser(AppUserModel model)
        {
            var appUser = new AppUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
                
            };

            try
            {
                var result = await _userManager.CreateAsync(appUser,model.Password);
                return Ok(result);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }


    }
}


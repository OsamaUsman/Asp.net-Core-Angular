using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using ServerApp.Repository.Controller;
using ServerApp.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : AppController<Rating, RatingRepository>
    {
        RatingRepository _Rr;
        public RatingsController(RatingRepository Rr) : base(Rr) 
        {
            _Rr = Rr;
        }
    }
}

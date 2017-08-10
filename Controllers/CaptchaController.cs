using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactAPI.Entities;

namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    public class CaptchaController : Controller
    {
        // GET: api/Captcha
        [HttpGet]
        public Captcha Get()
        {
            return new Captcha();
        }
    }
}

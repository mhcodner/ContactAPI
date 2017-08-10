using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactAPI.Entities;

namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        // POST api/Contact
        [HttpPost]
        public void Post(ContactMessage Message)
        {
            
        }
    }
}

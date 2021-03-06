using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using TestCrud.Model;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using TestCrud.Helpers;
using TestCrud.Oops;

namespace TestCrud.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpPost("Index")]
        public IActionResult Index([FromBody] EmailModel model)
        {
            try
            {
                SendMail sendMail = new SendMail();
                sendMail.Send(model);
            }
            catch(Exception ex)
            { 
                throw ex;
            }
            return Ok("message sent successfully");
        }

        [HttpPost("Oops")]
        public IActionResult Oops()
        {
            //Test1 test1 = new Test1();

            //test1.MyProperty = 25;
            //test1.GetMarrks();

            //Test2 test2 = new Test2();
            //test2.

            Charger charger = new Charger();
            charger.ChargerPort();


            return Ok();
        }


        public class Test3 : IMobile
        {
            public void ChargerPort()
            {
                
            }

        }
    }
}
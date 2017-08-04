using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TR_api.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("api/Home/TicketBooking")]
        public bool TicketBooking(int id, string date, string time,string filmName,int seatNumber,int seatId,int price)
        {
            return true;
        }


        [HttpGet]
        [Route("api/Home/TimeTable")]
        public bool TimeTable(int id, string date, string time, string film, int price)
        {
            return true;
        }

         [HttpGet]
         [Route("api/Home/SeatsAvailability")]
        public bool SeatsAvailability(int id, string film, string date, string time, string seats)
        {
            return true;
        }
        
    }
}
    


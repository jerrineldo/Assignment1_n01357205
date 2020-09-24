using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01357205.Controllers
{
    public class SquareController : ApiController
    {
        //GET api/Square/5
        //input : integer
        //output: Returns the square of the integer input
        public int Get(int id)
        {
            return id * id;
        }
    }
}

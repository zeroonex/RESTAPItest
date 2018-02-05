using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTserverTest.Models;

namespace RESTserverTest.Controllers
{
    public class InputOutputController : ApiController
    {
      

        // GET: api/InputOutput/inputINT
        public INPUTdata Get(int number)
        {
            INPUTdata newinput = new INPUTdata();

            newinput.inputValue = number; // input integer value
            //newinput.multi7 = 7;
            //newinput.multi9 = 9;


                if ((number % 7 == 0) && (number % 9 == 0))
                {
                    newinput.returnValue = "SN"; // return output if input integer is multiple of 7 and 9
                }

                else if ((number % 7) == 0)
                {
                    newinput.returnValue = "S";// return output if input integer is multiple of 7
                }
               
                else if ((number % 9) == 0)               
                {
                    newinput.returnValue = "N"; // return output if input integer is multiple of 9
                }

                else
                { newinput.returnValue = number.ToString(); } // return output of of original input value if the input integer is NOT a multiple of 7 or 9


            return newinput;
        }

        // POST: api/InputOutput
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/InputOutput/5
        public void Put(int number, [FromBody]string value)
        {
        }

        // DELETE: api/InputOutput/5
        public void Delete(int number)
        {
        }
    }
}

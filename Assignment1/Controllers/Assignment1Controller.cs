using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class Assignment1Controller : ApiController
    {


        /// <summary>
        /// Ques.1. Calculate sum of input {id} and 10.
        /// </summary>
        /// <param name="id"> Integer Input</param>
        /// <example> eg. GET localhost/AddTen/21  -> 31</example>
        /// <example> eg. GET localhost/AddTen/0   -> 10</example>
        /// <returns> Integer Input plus 10</returns>

        [HttpGet]
            [Route("api/Assignment1/AddTen/{id}")]
            public int AddTen(int id)
            {
                return (id + 10);

            }

        /// <summary>
        /// Ques.2. Calculate the square of the integer input {id}.
        /// </summary>
        /// <param name="id"> Integer Input</param>
        /// <example> eg. GET localhost/Square/2  -> 4</example>
        /// <example> eg. GET localhost/Square/-2 -> 4</example>
        /// <returns> Square of Integer Input</returns>


        [HttpGet]
            [Route("api/Assignment1/Square/{id}")]
            public int Square(int id)

            {
                double Power2 = Math.Pow(id, 2);

                return (int)Power2;
            }



        /// <summary>
        /// Ques.3. Returns the string “Hello World!” 
        /// </summary>
        /// <example> eg. POST localhost/Greeting -> “Hello World!”</example>
        /// <returns> “Hello World!” </returns>
        

        [HttpPost]
        [Route("api/Assignment1/Greeting")]

        public string Greeting()

        {
            return ("Hello World!”");
        }



        /// <summary>
        /// Ques.4. Returns the string “Greetings to {id} people!” where id is an integer value.” 
        /// </summary>
        /// <example> eg. GET localhost/Greeting/3 -> Greetings to 3 people! </example>
        /// <returns> Greetings to {id} people! </returns>


        [HttpGet]
        [Route("api/Assignment1/Greeting/{id}")]

        public string Greeting (int id)

        {
            return (string)("Greetings to " + id + " people!");

        }

        /// <summary>
        /// Ques.5. Create a method which has an input {id}, and applies four mathematical operations to it.
        /// </summary>
        /// <param name="id"></param>
        /// <example> eg. GET localhost/NumberMachine/1  -> {[(1+10)*4]-7}/2 = 18.5</example>
        /// 
        /// <returns>Result after applying four mathematical operations on the integer</returns>

        [HttpGet]
        [Route("api/Assignment1/NumberMachine/{id}")]
        public decimal NumberMachine(int id)

        {
            Decimal SumTen = id + 10;
            Decimal TimesFour = SumTen * 4;
            Decimal MinusSeven = TimesFour - 7;
            Decimal FinalDigit = MinusSeven / 2;
            return (decimal)(FinalDigit);



        }



        /// <summary>
        /// Question 6 : Initiative Question : You are charging your client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance,
        /// plus an additional 13% HST.The input { id }
        /// represents the number of days which has elapsed
        /// since the beginning of the hosting.Output 3 strings which describe the total hosting cost. To solve this problem we need to comput
        /// number of fortnights we have hosted customer's web. Minimum FN is 1 which is considered for period of 0 to 14 days and after each
        /// 14 days we should charge customer for 1 more FN. Then, total number of FN is computed by total days divided on 14 plus 1, which is 
        /// minimum amount of FN. RealFN variable is the result. After that, we need to comput NetCost which is 5.5 CAD for each FN. As we are 
        /// dealing with money, all costs should be rounded in two decimal using Math.Round function. HST is calculated by Multiplying NetCost 
        /// to 13% and Finally TotalCost is the sum of NetCost and HST. Since we need a combination of digits and strings as output, our method 
        /// should return string. 
        /// </summary>
        /// <param name="id"></param>
        /// <example> eg GET .../HostingCost/0 -> 1 fortnights at $5.50/FN = $5.50 CAD
        /// and HST 13% = $0.72 CAD and Total = $6.22 CAD </example> 
        /// <returns> “Number of fortnights at $5.50/FN = Net Cost in  CAD” and
        /// “13% HST in CAD” and “Total cost of hosting in CAD”</returns>

        [HttpGet]
        [Route("api/Assignment1/HostingCost/{id}")]
        public string HostingCost (int id)

        {
            decimal quotient = id / 14;
            quotient = Math.Floor(quotient);
            decimal RealFN = quotient + 1;
            decimal NetCost = Math.Round((RealFN * 11 / 2),2);
            decimal HSTPlus = Math.Round((NetCost * 13 / 100),2);
            decimal TotalCost = Math.Round((NetCost + HSTPlus ),2);
           
            return (RealFN + " fortnights at $5.50/FN = " + NetCost + " CAD, and HST 13% = " + HSTPlus + " CAD, and Total = " + TotalCost + " CAD.");

        }



    }

}


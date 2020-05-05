using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoanAPI.BusinessCalc;

namespace LoanAPI.Controller
{
    
    public class EMIController : ApiController
    {
        private ICalculator _calculator = new EMICalculator();

        /// <summary>
        /// Get request to return emi details
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="months"></param>
        /// <returns> http response</returns>
        public HttpResponseMessage Get(float principal, int months)
        {
            if(months>0 && principal > 0)
            {
                try
                {
                    var response = _calculator.getEmiDetails(principal, months);
                    return this.Request.CreateResponse(HttpStatusCode.OK, response);
                }
                catch(Exception e)
                {
                    return this.Request.CreateResponse(HttpStatusCode.InternalServerError, e);
                }
            }
            return this.Request.CreateResponse(HttpStatusCode.ExpectationFailed, "Principal and loan tenure must be greater than zero");

        }
    }
}

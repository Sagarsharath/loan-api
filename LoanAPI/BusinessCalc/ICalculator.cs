using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanAPI.Models;

namespace LoanAPI.BusinessCalc
{
    interface ICalculator
    {
        /// <summary>
        /// Method to return emi details as whole after calculation
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="tenure"></param>
        /// <returns> EMIInfo </returns>
        EMIInfo getEmiDetails(float principal, int tenure);        
    }
}

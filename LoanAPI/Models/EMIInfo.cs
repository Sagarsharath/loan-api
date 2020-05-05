using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoanAPI.Models
{
    /// <summary>
    /// Basic EMI Details
    /// </summary>
    public class EMIInfo
    {
        [JsonProperty(PropertyName ="Principal Amount")]
        public float principalAmount { get; set; }
        [JsonProperty(PropertyName = "Loan Creation Date")]
        public string disbursalDate { get; set; }
        [JsonProperty(PropertyName = "No of EMI's")]
        public int noOfMonths { get; set; }
        [JsonProperty(PropertyName = "EMI Details")]
        public List<MonthlyEMIInfo> eachEmi { get; set; }
        [JsonProperty(PropertyName = "Total Payable Amount")]
        public float totalPayableAmount { get; set; }
    }
}
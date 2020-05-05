using Newtonsoft.Json;

namespace LoanAPI.Models
{
    /// <summary>
    /// Attributes for a month
    /// </summary>
    public class MonthlyEMIInfo
    {
        [JsonProperty(PropertyName = "EMI No")]
        public int emiNumber { get; set; }
        [JsonProperty(PropertyName = "Principal EMI")]
        public float principalEMiAmount { get; set; }
        [JsonProperty(PropertyName = "Interest EMI")]
        public float interestEMiAmount { get; set; }
        [JsonProperty(PropertyName = "Total EMI")]
        public float totalEMiAmount { get; set; }
        [JsonProperty(PropertyName = "EMI Date")]
        public string emiDate { get; set; }
        [JsonProperty(PropertyName = "Principal Remaining")]
        public float pendingAmount { get; set; }

    }
}
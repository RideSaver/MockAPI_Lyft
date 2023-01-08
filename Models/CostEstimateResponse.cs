using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract(Name = "CostEstimateResponse")]
    public class CostEstimateResponse : IEquatable<CostEstimateResponse>
    { 
        [DataMember(Name="cost_estimates")]
        public List<CostEstimate> CostEstimates { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CostEstimateResponse {\n");
            sb.Append("  CostEstimates: ").Append(CostEstimates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CostEstimateResponse)obj);
        }
        public bool Equals(CostEstimateResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CostEstimates == other.CostEstimates ||
                    CostEstimates != null &&
                    CostEstimates.SequenceEqual(other.CostEstimates)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (CostEstimates != null)
                    hashCode = hashCode * 59 + CostEstimates.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CostEstimateResponse left, CostEstimateResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CostEstimateResponse left, CostEstimateResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

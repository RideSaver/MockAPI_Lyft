using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class EtaEstimateResponse : IEquatable<EtaEstimateResponse>
    { 
        [DataMember(Name="eta_estimates")]
        public List<Eta> EtaEstimates { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EtaEstimateResponse {\n");
            sb.Append("  EtaEstimates: ").Append(EtaEstimates).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EtaEstimateResponse)obj);
        }
        public bool Equals(EtaEstimateResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EtaEstimates == other.EtaEstimates ||
                    EtaEstimates != null &&
                    EtaEstimates.SequenceEqual(other.EtaEstimates)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (EtaEstimates != null)
                    hashCode = hashCode * 59 + EtaEstimates.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EtaEstimateResponse left, EtaEstimateResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EtaEstimateResponse left, EtaEstimateResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

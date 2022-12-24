using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class InlineResponse200 : IEquatable<InlineResponse200>
    { 
        [DataMember(Name="ride_history")]
        public List<RideDetail> RideHistory { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  RideHistory: ").Append(RideHistory).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse200)obj);
        }
        public bool Equals(InlineResponse200 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RideHistory == other.RideHistory ||
                    RideHistory != null &&
                    RideHistory.SequenceEqual(other.RideHistory)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RideHistory != null)
                    hashCode = hashCode * 59 + RideHistory.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse200 left, InlineResponse200 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse200 left, InlineResponse200 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

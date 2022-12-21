using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class RideTypesResponse : IEquatable<RideTypesResponse>
    { 

        [DataMember(Name="ride_types")]
        public List<RideType> RideTypes { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideTypesResponse {\n");
            sb.Append("  RideTypes: ").Append(RideTypes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RideTypesResponse)obj);
        }
        public bool Equals(RideTypesResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RideTypes == other.RideTypes ||
                    RideTypes != null &&
                    RideTypes.SequenceEqual(other.RideTypes)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RideTypes != null)
                    hashCode = hashCode * 59 + RideTypes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RideTypesResponse left, RideTypesResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RideTypesResponse left, RideTypesResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class NearbyDriversResponse : IEquatable<NearbyDriversResponse>
    { 

        [DataMember(Name="nearby_drivers")]
        public List<NearbyDriversByRideType> NearbyDrivers { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NearbyDriversResponse {\n");
            sb.Append("  NearbyDrivers: ").Append(NearbyDrivers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NearbyDriversResponse)obj);
        }
        public bool Equals(NearbyDriversResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NearbyDrivers == other.NearbyDrivers ||
                    NearbyDrivers != null &&
                    NearbyDrivers.SequenceEqual(other.NearbyDrivers)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (NearbyDrivers != null)
                    hashCode = hashCode * 59 + NearbyDrivers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NearbyDriversResponse left, NearbyDriversResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NearbyDriversResponse left, NearbyDriversResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

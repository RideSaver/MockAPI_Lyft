using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class NearbyDriversByRideType : IEquatable<NearbyDriversByRideType>
    { 
        [DataMember(Name="ride_type")]
        public string RideType { get; set; }

        [DataMember(Name="drivers")]
        public List<NearbyDriver> Drivers { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NearbyDriversByRideType {\n");
            sb.Append("  RideType: ").Append(RideType).Append("\n");
            sb.Append("  Drivers: ").Append(Drivers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NearbyDriversByRideType)obj);
        }

        public bool Equals(NearbyDriversByRideType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RideType == other.RideType ||
                    RideType != null &&
                    RideType.Equals(other.RideType)
                ) && 
                (
                    Drivers == other.Drivers ||
                    Drivers != null &&
                    Drivers.SequenceEqual(other.Drivers)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RideType != null)
                    hashCode = hashCode * 59 + RideType.GetHashCode();
                    if (Drivers != null)
                    hashCode = hashCode * 59 + Drivers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NearbyDriversByRideType left, NearbyDriversByRideType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NearbyDriversByRideType left, NearbyDriversByRideType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

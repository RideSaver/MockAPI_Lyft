using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class NearbyDriver : IEquatable<NearbyDriver>
    { 
        [DataMember(Name="locations")]
        public List<LatLng> Locations { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NearbyDriver {\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NearbyDriver)obj);
        }
        public bool Equals(NearbyDriver other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Locations == other.Locations ||
                    Locations != null &&
                    Locations.SequenceEqual(other.Locations)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Locations != null)
                    hashCode = hashCode * 59 + Locations.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NearbyDriver left, NearbyDriver right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NearbyDriver left, NearbyDriver right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

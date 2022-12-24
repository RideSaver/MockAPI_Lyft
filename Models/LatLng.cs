using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class LatLng : IEquatable<LatLng>
    { 
        [Required]
        [DataMember(Name="lat")]
        public double? Lat { get; set; }

        [Required]
        [DataMember(Name="lng")]
        public double? Lng { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LatLng {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LatLng)obj);
        }
        public bool Equals(LatLng other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Lat == other.Lat ||
                    Lat != null &&
                    Lat.Equals(other.Lat)
                ) && 
                (
                    Lng == other.Lng ||
                    Lng != null &&
                    Lng.Equals(other.Lng)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Lat != null)
                    hashCode = hashCode * 59 + Lat.GetHashCode();
                    if (Lng != null)
                    hashCode = hashCode * 59 + Lng.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LatLng left, LatLng right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LatLng left, LatLng right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

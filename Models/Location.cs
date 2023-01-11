using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    [DataContract(Name = "Location")]
    public class Location : IEquatable<Location> , IValidatableObject
    {
        [JsonConstructorAttribute]
        public Location(double lat = default(double), double lng = default(double), string? address = default(string))
        {
            this.Lat = lat;
            this.Lng = lng;
            this.Address = address;
        }

        [DataMember(Name = "lat", EmitDefaultValue = false)]
        public double Lat { get; set; }

        [DataMember(Name = "lng", EmitDefaultValue = false)]
        public double Lng { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string? Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Location)obj);
        }
        public bool Equals(Location other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                return hashCode;
            }
        }
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Location left, Location right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Location left, Location right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

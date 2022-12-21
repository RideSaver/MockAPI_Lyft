using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class Ride : IEquatable<Ride>
    { 
        [DataMember(Name="ride_id")]
        public string RideId { get; set; }

        [Required]
        [DataMember(Name="ride_type")]
        public RideTypeEnum RideType { get; set; }

        [Required]
        [DataMember(Name="origin")]
        public Location Origin { get; set; }

        [DataMember(Name="destination")]
        public Location Destination { get; set; }

        [DataMember(Name="primetime_confirmation_token")]
        public string PrimetimeConfirmationToken { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ride {\n");
            sb.Append("  RideId: ").Append(RideId).Append("\n");
            sb.Append("  RideType: ").Append(RideType).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  PrimetimeConfirmationToken: ").Append(PrimetimeConfirmationToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Ride)obj);
        }
        public bool Equals(Ride other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RideId == other.RideId ||
                    RideId != null &&
                    RideId.Equals(other.RideId)
                ) && 
                (
                    RideType == other.RideType ||
                    RideType != null &&
                    RideType.Equals(other.RideType)
                ) && 
                (
                    Origin == other.Origin ||
                    Origin != null &&
                    Origin.Equals(other.Origin)
                ) && 
                (
                    Destination == other.Destination ||
                    Destination != null &&
                    Destination.Equals(other.Destination)
                ) && 
                (
                    PrimetimeConfirmationToken == other.PrimetimeConfirmationToken ||
                    PrimetimeConfirmationToken != null &&
                    PrimetimeConfirmationToken.Equals(other.PrimetimeConfirmationToken)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RideId != null)
                    hashCode = hashCode * 59 + RideId.GetHashCode();
                    if (RideType != null)
                    hashCode = hashCode * 59 + RideType.GetHashCode();
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                    if (Destination != null)
                    hashCode = hashCode * 59 + Destination.GetHashCode();
                    if (PrimetimeConfirmationToken != null)
                    hashCode = hashCode * 59 + PrimetimeConfirmationToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Ride left, Ride right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Ride left, Ride right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

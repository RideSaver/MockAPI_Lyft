using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class RideRequest : IEquatable<RideRequest>
    { 
        [DataMember(Name="ride_id")]
        public string RideId { get; set; }

        [DataMember(Name="status")]
        public RideStatusEnum Status { get; set; }

        [DataMember(Name="origin")]
        public Location Origin { get; set; }

        [DataMember(Name="destination")]
        public Location Destination { get; set; }

        [DataMember(Name="passenger")]
        public PassengerDetail Passenger { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideRequest {\n");
            sb.Append("  RideId: ").Append(RideId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Passenger: ").Append(Passenger).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RideRequest)obj);
        }
        public bool Equals(RideRequest other)
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
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
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
                    Passenger == other.Passenger ||
                    Passenger != null &&
                    Passenger.Equals(other.Passenger)
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
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                    if (Destination != null)
                    hashCode = hashCode * 59 + Destination.GetHashCode();
                    if (Passenger != null)
                    hashCode = hashCode * 59 + Passenger.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RideRequest left, RideRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RideRequest left, RideRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

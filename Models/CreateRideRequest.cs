using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    [DataContract(Name = "CreateRideRequest")]
    public class CreateRideRequest : IEquatable<CreateRideRequest> , IValidatableObject
    {
        [JsonConstructorAttribute]
        protected CreateRideRequest() { }

        public CreateRideRequest(string? costToken = default(string), RideTypeEnum rideType = default(RideTypeEnum), Location origin = default(Location), Location destination = default(Location), PassengerDetail? passenger = default(PassengerDetail))
        {
            this.CostToken = costToken;
            this.RideType = rideType;
            this.Origin = origin;
            this.Destination = destination;
            this.Passenger = passenger;
        }

        [DataMember(Name = "ride_type", EmitDefaultValue = false)]
        public RideTypeEnum? RideType { get; set; }

        [DataMember(Name = "cost_token", EmitDefaultValue = false)]
        public string? CostToken { get; set; }

        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public Location? Origin { get; set; }

        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public Location? Destination { get; set; }

        [DataMember(Name = "passenger", EmitDefaultValue = false)]
        public PassengerDetail? Passenger { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRideRequest {\n");
            sb.Append("  CostToken: ").Append(CostToken).Append("\n");
            sb.Append("  RideType: ").Append(RideType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateRideRequest)obj);
        }
        public bool Equals(CreateRideRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CostToken == other.CostToken ||
                    CostToken != null &&
                    CostToken.Equals(other.CostToken)
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
                    if (CostToken != null)
                    hashCode = hashCode * 59 + CostToken.GetHashCode();
                    if (RideType != null)
                    hashCode = hashCode * 59 + RideType.GetHashCode();
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                    if (Destination != null)
                    hashCode = hashCode * 59 + Destination.GetHashCode();
                    if (Passenger != null)
                    hashCode = hashCode * 59 + Passenger.GetHashCode();
                return hashCode;
            }
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
        #region Operators
#pragma warning disable 1591

        public static bool operator ==(CreateRideRequest left, CreateRideRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateRideRequest left, CreateRideRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

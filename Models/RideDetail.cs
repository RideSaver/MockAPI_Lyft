using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    /// <summary>
    /// Detail information about a ride
    /// </summary>
    [DataContract(Name = "RideDetail")]
    public partial class RideDetail : IEquatable<RideDetail>, IValidatableObject
    {
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public RideStatusEnum? Status { get; set; }

        [DataMember(Name = "rideType", EmitDefaultValue = false)]
        public RideTypeEnumWithOther? RideType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum CanCancelEnum
        {
            [EnumMember(Value = "driver")]
            Driver = 1,

            [EnumMember(Value = "passenger")]
            Passenger = 2,

            [EnumMember(Value = "dispatcher")]
            Dispatcher = 3

        }
        public RideDetail(string rideId = default(string), RideStatusEnum? status = default(RideStatusEnum?), RideTypeEnumWithOther? rideType = default(RideTypeEnumWithOther?), PassengerDetail passenger = default(PassengerDetail), DriverDetail driver = default(DriverDetail), VehicleDetail vehicle = default(VehicleDetail), RideLocation origin = default(RideLocation), RideLocation destination = default(RideLocation), PickupDropoffLocation pickup = default(PickupDropoffLocation), PickupDropoffLocation dropoff = default(PickupDropoffLocation), RideLocation location = default(RideLocation), string primetimePercentage = default(string), Cost price = default(Cost), List<LineItem> lineItems = default(List<LineItem>), List<CanCancelEnum> canCancel = default(List<CanCancelEnum>), string canceledBy = default(string), CancellationCost cancellationPrice = default(CancellationCost), int rating = default(int), string feedback = default(string), string routeUrl = default(string), DateTimeOffset requestedAt = default(DateTimeOffset))
        {
            this.RideId = rideId;
            this.Status = status;
            this.RideType = rideType;
            this.Passenger = passenger;
            this.Driver = driver;
            this.Vehicle = vehicle;
            this.Origin = origin;
            this.Destination = destination;
            this.Pickup = pickup;
            this.Dropoff = dropoff;
            this.Location = location;
            this.PrimetimePercentage = primetimePercentage;
            this.Price = price;
            this.LineItems = lineItems;
            this.CanCancel = canCancel;
            this.CanceledBy = canceledBy;
            this.CancellationPrice = cancellationPrice;
            this.Rating = rating;
            this.Feedback = feedback;
            this.RouteUrl = routeUrl;
            this.RequestedAt = requestedAt;
        }
        [DataMember(Name = "rideId", EmitDefaultValue = false)]
        public string RideId { get; set; }

        [DataMember(Name = "passenger", EmitDefaultValue = false)]
        public PassengerDetail Passenger { get; set; }

        [DataMember(Name = "driver", EmitDefaultValue = false)]
        public DriverDetail Driver { get; set; }

        [DataMember(Name = "vehicle", EmitDefaultValue = false)]
        public VehicleDetail Vehicle { get; set; }

        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public RideLocation Origin { get; set; }

        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public RideLocation Destination { get; set; }

        [DataMember(Name = "pickup", EmitDefaultValue = false)]
        public PickupDropoffLocation Pickup { get; set; }

        [DataMember(Name = "dropoff", EmitDefaultValue = false)]
        public PickupDropoffLocation Dropoff { get; set; }

        [DataMember(Name = "location", EmitDefaultValue = false)]
        public RideLocation Location { get; set; }

        [DataMember(Name = "primetimePercentage", EmitDefaultValue = false)]
        public string PrimetimePercentage { get; set; }

        [DataMember(Name = "price", EmitDefaultValue = false)]
        public Cost Price { get; set; }

        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        [DataMember(Name = "canCancel", EmitDefaultValue = false)]
        public List<RideDetail.CanCancelEnum> CanCancel { get; set; }

        [DataMember(Name = "canceledBy", EmitDefaultValue = false)]
        public string CanceledBy { get; set; }

        [DataMember(Name = "cancellationPrice", EmitDefaultValue = false)]
        public CancellationCost CancellationPrice { get; set; }

        [DataMember(Name = "rating", EmitDefaultValue = false)]
        public int Rating { get; set; }

        [DataMember(Name = "feedback", EmitDefaultValue = false)]
        public string Feedback { get; set; }

        [DataMember(Name = "route_url", EmitDefaultValue = false)]
        public string RouteUrl { get; set; }

        [DataMember(Name = "requestedAt", EmitDefaultValue = false)]
        public DateTimeOffset RequestedAt { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideDetail {\n");
            sb.Append("  RideId: ").Append(RideId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            //sb.Append("  RideType: ").Append(RideType).Append("\n");
            sb.Append("  Passenger: ").Append(Passenger).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
            sb.Append("  Vehicle: ").Append(Vehicle).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Pickup: ").Append(Pickup).Append("\n");
            sb.Append("  Dropoff: ").Append(Dropoff).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PrimetimePercentage: ").Append(PrimetimePercentage).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  CanCancel: ").Append(CanCancel).Append("\n");
            sb.Append("  CanceledBy: ").Append(CanceledBy).Append("\n");
            sb.Append("  CancellationPrice: ").Append(CancellationPrice).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  RouteUrl: ").Append(RouteUrl).Append("\n");
            sb.Append("  RequestedAt: ").Append(RequestedAt).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RideDetail)obj);
        }
        public bool Equals(RideDetail other)
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
                /*(
                    RideType == other.RideType ||
                    RideType != null &&
                    RideType.Equals(other.RideType)
                ) && */
                (
                    Passenger == other.Passenger ||
                    Passenger != null &&
                    Passenger.Equals(other.Passenger)
                ) && 
                (
                    Driver == other.Driver ||
                    Driver != null &&
                    Driver.Equals(other.Driver)
                ) && 
                (
                    Vehicle == other.Vehicle ||
                    Vehicle != null &&
                    Vehicle.Equals(other.Vehicle)
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
                    Pickup == other.Pickup ||
                    Pickup != null &&
                    Pickup.Equals(other.Pickup)
                ) && 
                (
                    Dropoff == other.Dropoff ||
                    Dropoff != null &&
                    Dropoff.Equals(other.Dropoff)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    PrimetimePercentage == other.PrimetimePercentage ||
                    PrimetimePercentage != null &&
                    PrimetimePercentage.Equals(other.PrimetimePercentage)
                ) && 
                (
                    Price == other.Price ||
                    Price != null &&
                    Price.Equals(other.Price)
                ) && 
                (
                    LineItems == other.LineItems ||
                    LineItems != null &&
                    LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    CanCancel == other.CanCancel ||
                    CanCancel != null &&
                    CanCancel.SequenceEqual(other.CanCancel)
                ) && 
                (
                    CanceledBy == other.CanceledBy ||
                    CanceledBy != null &&
                    CanceledBy.Equals(other.CanceledBy)
                ) && 
                (
                    CancellationPrice == other.CancellationPrice ||
                    CancellationPrice != null &&
                    CancellationPrice.Equals(other.CancellationPrice)
                ) && 
                (
                    Rating == other.Rating ||
                    Rating != null &&
                    Rating.Equals(other.Rating)
                ) && 
                (
                    Feedback == other.Feedback ||
                    Feedback != null &&
                    Feedback.Equals(other.Feedback)
                ) && 
                (
                    RouteUrl == other.RouteUrl ||
                    RouteUrl != null &&
                    RouteUrl.Equals(other.RouteUrl)
                ) && 
                (
                    RequestedAt == other.RequestedAt ||
                    RequestedAt != null &&
                    RequestedAt.Equals(other.RequestedAt)
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
                    /*if (RideType != null)
                    hashCode = hashCode * 59 + RideType.GetHashCode();*/
                    if (Passenger != null)
                    hashCode = hashCode * 59 + Passenger.GetHashCode();
                    if (Driver != null)
                    hashCode = hashCode * 59 + Driver.GetHashCode();
                    if (Vehicle != null)
                    hashCode = hashCode * 59 + Vehicle.GetHashCode();
                    if (Origin != null)
                    hashCode = hashCode * 59 + Origin.GetHashCode();
                    if (Destination != null)
                    hashCode = hashCode * 59 + Destination.GetHashCode();
                    if (Pickup != null)
                    hashCode = hashCode * 59 + Pickup.GetHashCode();
                    if (Dropoff != null)
                    hashCode = hashCode * 59 + Dropoff.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (PrimetimePercentage != null)
                    hashCode = hashCode * 59 + PrimetimePercentage.GetHashCode();
                    if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (LineItems != null)
                    hashCode = hashCode * 59 + LineItems.GetHashCode();
                    if (CanCancel != null)
                    hashCode = hashCode * 59 + CanCancel.GetHashCode();
                    if (CanceledBy != null)
                    hashCode = hashCode * 59 + CanceledBy.GetHashCode();
                    if (CancellationPrice != null)
                    hashCode = hashCode * 59 + CancellationPrice.GetHashCode();
                    if (Rating != null)
                    hashCode = hashCode * 59 + Rating.GetHashCode();
                    if (Feedback != null)
                    hashCode = hashCode * 59 + Feedback.GetHashCode();
                    if (RouteUrl != null)
                    hashCode = hashCode * 59 + RouteUrl.GetHashCode();
                    if (RequestedAt != null)
                    hashCode = hashCode * 59 + RequestedAt.GetHashCode();
                return hashCode;
            }
        }

        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(RideDetail left, RideDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RideDetail left, RideDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

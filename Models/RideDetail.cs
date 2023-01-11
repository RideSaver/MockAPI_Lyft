using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using JsonConverter = Newtonsoft.Json.JsonConverter;
using JsonConverterAttribute = Newtonsoft.Json.JsonConverterAttribute;

namespace LyftAPI.Models
{
    /// <summary>
    /// Detail information about a ride
    /// </summary>
    [DataContract]
    public class RideDetail : IEquatable<RideDetail>
    { 
        [DataMember(Name = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RideStatusEnum? Status { get; set; } = RideStatusEnum.PendingEnum;

        [DataMember(Name = "ride_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RideTypeEnumWithOther? RideType { get; set; } = RideTypeEnumWithOther.LyftEnum;

        [DataMember(Name = "ride_id")]
        public string RideId { get; set; }

        [DataMember(Name = "passenger")]
        public PassengerDetail? Passenger { get; set; }

        [DataMember(Name = "driver")]
        public DriverDetail? Driver { get; set; }

        [DataMember(Name = "vehicle")]
        public VehicleDetail? Vehicle { get; set; }

        [DataMember(Name = "origin")]
        public RideLocation? Origin { get; set; }

        [DataMember(Name = "destination")]
        public RideLocation? Destination { get; set; }

        [DataMember(Name = "pickup")]
        public PickupDropoffLocation? Pickup { get; set; }

        [DataMember(Name = "dropoff")]
        public PickupDropoffLocation? Dropoff { get; set; }

        [DataMember(Name = "location")]
        public RideLocation? Location { get; set; }

        [DataMember(Name = "primetime_percentage")]
        public string? PrimetimePercentage { get; set; }

        [DataMember(Name = "price")]
        public Cost? Price { get; set; }

        [DataMember(Name = "line_items")]
        public List<LineItem>? LineItems { get; set; }

        [DataMember(Name = "can_cancel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<RideDetail.CanCancelEnum>? CanCancel { get; set; }

        [DataMember(Name = "canceled_by")]
        public string? CanceledBy { get; set; }

        [DataMember(Name = "cancellation_price")]
        public CancellationCost? CancellationPrice { get; set; }

        [DataMember(Name = "rating")]
        public int? Rating { get; set; }

        [DataMember(Name = "feedback")]
        public string? Feedback { get; set; }

        [DataMember(Name = "route_url")]
        public string RouteUrl { get; set; } = "Exempt";

        [DataMember(Name = "requested_at")]
        public DateTimeOffset? RequestedAt { get; set; }

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
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideDetail {\n");
            sb.Append("  RideId: ").Append(RideId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RideType: ").Append(RideType).Append("\n");
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
                (
                    RideType == other.RideType ||
                    RideType != null &&
                    RideType.Equals(other.RideType)
                ) &&
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

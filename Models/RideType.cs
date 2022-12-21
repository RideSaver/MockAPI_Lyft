using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class RideType : IEquatable<RideType>
    { 
        [DataMember(Name="ride_type")]
        public RideTypeEnum _RideType { get; set; }

        [DataMember(Name="display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name="seats")]
        public int? Seats { get; set; }

        [DataMember(Name="image_url")]
        public string ImageUrl { get; set; }

        [DataMember(Name="pricing_details")]
        public PricingDetails PricingDetails { get; set; }

        [DataMember(Name="scheduled_pricing_details")]
        public PricingDetails ScheduledPricingDetails { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideType {\n");
            sb.Append("  _RideType: ").Append(_RideType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Seats: ").Append(Seats).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  PricingDetails: ").Append(PricingDetails).Append("\n");
            sb.Append("  ScheduledPricingDetails: ").Append(ScheduledPricingDetails).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RideType)obj);
        }
        public bool Equals(RideType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    _RideType == other._RideType ||
                    _RideType != null &&
                    _RideType.Equals(other._RideType)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    Seats == other.Seats ||
                    Seats != null &&
                    Seats.Equals(other.Seats)
                ) && 
                (
                    ImageUrl == other.ImageUrl ||
                    ImageUrl != null &&
                    ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    PricingDetails == other.PricingDetails ||
                    PricingDetails != null &&
                    PricingDetails.Equals(other.PricingDetails)
                ) && 
                (
                    ScheduledPricingDetails == other.ScheduledPricingDetails ||
                    ScheduledPricingDetails != null &&
                    ScheduledPricingDetails.Equals(other.ScheduledPricingDetails)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (_RideType != null)
                    hashCode = hashCode * 59 + _RideType.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (Seats != null)
                    hashCode = hashCode * 59 + Seats.GetHashCode();
                    if (ImageUrl != null)
                    hashCode = hashCode * 59 + ImageUrl.GetHashCode();
                    if (PricingDetails != null)
                    hashCode = hashCode * 59 + PricingDetails.GetHashCode();
                    if (ScheduledPricingDetails != null)
                    hashCode = hashCode * 59 + ScheduledPricingDetails.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RideType left, RideType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RideType left, RideType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

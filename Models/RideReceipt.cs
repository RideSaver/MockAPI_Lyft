using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class RideReceipt : IEquatable<RideReceipt>
    { 

        [DataMember(Name="ride_id")]
        public string RideId { get; set; }

        [DataMember(Name="price")]
        public Cost Price { get; set; }

        [DataMember(Name="line_items")]
        public List<LineItem> LineItems { get; set; }

        [DataMember(Name="charges")]
        public List<Charge> Charges { get; set; }

        [DataMember(Name="requested_at")]
        public DateTime? RequestedAt { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideReceipt {\n");
            sb.Append("  RideId: ").Append(RideId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RideReceipt)obj);
        }
        public bool Equals(RideReceipt other)
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
                    Charges == other.Charges ||
                    Charges != null &&
                    Charges.SequenceEqual(other.Charges)
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
                    if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (LineItems != null)
                    hashCode = hashCode * 59 + LineItems.GetHashCode();
                    if (Charges != null)
                    hashCode = hashCode * 59 + Charges.GetHashCode();
                    if (RequestedAt != null)
                    hashCode = hashCode * 59 + RequestedAt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RideReceipt left, RideReceipt right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RideReceipt left, RideReceipt right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

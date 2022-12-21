using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class PricingDetails : IEquatable<PricingDetails>
    { 
        [DataMember(Name="base_charge")]
        public int? BaseCharge { get; set; }

        [DataMember(Name="cancel_penalty_amount")]
        public int? CancelPenaltyAmount { get; set; }

        [DataMember(Name="cost_minimum")]
        public int? CostMinimum { get; set; }

        [DataMember(Name="cost_per_mile")]
        public int? CostPerMile { get; set; }

        [DataMember(Name="cost_per_minute")]
        public int? CostPerMinute { get; set; }

        [DataMember(Name="currency")]
        public string Currency { get; set; }

        [DataMember(Name="trust_and_service")]
        public int? TrustAndService { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PricingDetails {\n");
            sb.Append("  BaseCharge: ").Append(BaseCharge).Append("\n");
            sb.Append("  CancelPenaltyAmount: ").Append(CancelPenaltyAmount).Append("\n");
            sb.Append("  CostMinimum: ").Append(CostMinimum).Append("\n");
            sb.Append("  CostPerMile: ").Append(CostPerMile).Append("\n");
            sb.Append("  CostPerMinute: ").Append(CostPerMinute).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TrustAndService: ").Append(TrustAndService).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PricingDetails)obj);
        }
        public bool Equals(PricingDetails other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BaseCharge == other.BaseCharge ||
                    BaseCharge != null &&
                    BaseCharge.Equals(other.BaseCharge)
                ) && 
                (
                    CancelPenaltyAmount == other.CancelPenaltyAmount ||
                    CancelPenaltyAmount != null &&
                    CancelPenaltyAmount.Equals(other.CancelPenaltyAmount)
                ) && 
                (
                    CostMinimum == other.CostMinimum ||
                    CostMinimum != null &&
                    CostMinimum.Equals(other.CostMinimum)
                ) && 
                (
                    CostPerMile == other.CostPerMile ||
                    CostPerMile != null &&
                    CostPerMile.Equals(other.CostPerMile)
                ) && 
                (
                    CostPerMinute == other.CostPerMinute ||
                    CostPerMinute != null &&
                    CostPerMinute.Equals(other.CostPerMinute)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    TrustAndService == other.TrustAndService ||
                    TrustAndService != null &&
                    TrustAndService.Equals(other.TrustAndService)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (BaseCharge != null)
                    hashCode = hashCode * 59 + BaseCharge.GetHashCode();
                    if (CancelPenaltyAmount != null)
                    hashCode = hashCode * 59 + CancelPenaltyAmount.GetHashCode();
                    if (CostMinimum != null)
                    hashCode = hashCode * 59 + CostMinimum.GetHashCode();
                    if (CostPerMile != null)
                    hashCode = hashCode * 59 + CostPerMile.GetHashCode();
                    if (CostPerMinute != null)
                    hashCode = hashCode * 59 + CostPerMinute.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (TrustAndService != null)
                    hashCode = hashCode * 59 + TrustAndService.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PricingDetails left, PricingDetails right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PricingDetails left, PricingDetails right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

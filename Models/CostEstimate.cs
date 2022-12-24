using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class CostEstimate : IEquatable<CostEstimate>
    { 
        [DataMember(Name="ride_type")]
        public RideTypeEnum RideType { get; set; }

        [DataMember(Name="display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name="currency")]
        public string Currency { get; set; }

        [DataMember(Name="estimated_cost_cents_min")]
        public int? EstimatedCostCentsMin { get; set; }

        [DataMember(Name="estimated_cost_cents_max")]
        public int? EstimatedCostCentsMax { get; set; }

        [DataMember(Name="estimated_distance_miles")]
        public double? EstimatedDistanceMiles { get; set; }

        [DataMember(Name="estimated_duration_seconds")]
        public int? EstimatedDurationSeconds { get; set; }

        [DataMember(Name="is_valid_estimate")]
        public bool? IsValidEstimate { get; set; }

        [DataMember(Name="primetime_percentage")]
        public string PrimetimePercentage { get; set; }


        [DataMember(Name="primetime_confirmation_token")]
        public string PrimetimeConfirmationToken { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CostEstimate {\n");
            sb.Append("  RideType: ").Append(RideType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EstimatedCostCentsMin: ").Append(EstimatedCostCentsMin).Append("\n");
            sb.Append("  EstimatedCostCentsMax: ").Append(EstimatedCostCentsMax).Append("\n");
            sb.Append("  EstimatedDistanceMiles: ").Append(EstimatedDistanceMiles).Append("\n");
            sb.Append("  EstimatedDurationSeconds: ").Append(EstimatedDurationSeconds).Append("\n");
            sb.Append("  IsValidEstimate: ").Append(IsValidEstimate).Append("\n");
            sb.Append("  PrimetimePercentage: ").Append(PrimetimePercentage).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CostEstimate)obj);
        }
        public bool Equals(CostEstimate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RideType == other.RideType ||
                    RideType != null &&
                    RideType.Equals(other.RideType)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    EstimatedCostCentsMin == other.EstimatedCostCentsMin ||
                    EstimatedCostCentsMin != null &&
                    EstimatedCostCentsMin.Equals(other.EstimatedCostCentsMin)
                ) && 
                (
                    EstimatedCostCentsMax == other.EstimatedCostCentsMax ||
                    EstimatedCostCentsMax != null &&
                    EstimatedCostCentsMax.Equals(other.EstimatedCostCentsMax)
                ) && 
                (
                    EstimatedDistanceMiles == other.EstimatedDistanceMiles ||
                    EstimatedDistanceMiles != null &&
                    EstimatedDistanceMiles.Equals(other.EstimatedDistanceMiles)
                ) && 
                (
                    EstimatedDurationSeconds == other.EstimatedDurationSeconds ||
                    EstimatedDurationSeconds != null &&
                    EstimatedDurationSeconds.Equals(other.EstimatedDurationSeconds)
                ) && 
                (
                    IsValidEstimate == other.IsValidEstimate ||
                    IsValidEstimate != null &&
                    IsValidEstimate.Equals(other.IsValidEstimate)
                ) && 
                (
                    PrimetimePercentage == other.PrimetimePercentage ||
                    PrimetimePercentage != null &&
                    PrimetimePercentage.Equals(other.PrimetimePercentage)
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
                    if (RideType != null)
                    hashCode = hashCode * 59 + RideType.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (EstimatedCostCentsMin != null)
                    hashCode = hashCode * 59 + EstimatedCostCentsMin.GetHashCode();
                    if (EstimatedCostCentsMax != null)
                    hashCode = hashCode * 59 + EstimatedCostCentsMax.GetHashCode();
                    if (EstimatedDistanceMiles != null)
                    hashCode = hashCode * 59 + EstimatedDistanceMiles.GetHashCode();
                    if (EstimatedDurationSeconds != null)
                    hashCode = hashCode * 59 + EstimatedDurationSeconds.GetHashCode();
                    if (IsValidEstimate != null)
                    hashCode = hashCode * 59 + IsValidEstimate.GetHashCode();
                    if (PrimetimePercentage != null)
                    hashCode = hashCode * 59 + PrimetimePercentage.GetHashCode();
                    if (PrimetimeConfirmationToken != null)
                    hashCode = hashCode * 59 + PrimetimeConfirmationToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CostEstimate left, CostEstimate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CostEstimate left, CostEstimate right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class Eta : IEquatable<Eta>
    { 
        [DataMember(Name="ride_type")]
        public RideTypeEnum RideType { get; set; }

        [DataMember(Name="display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name="eta_seconds")]
        public int? EtaSeconds { get; set; }

        [DataMember(Name="is_valid_estimate")]
        public bool? IsValidEstimate { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eta {\n");
            sb.Append("  RideType: ").Append(RideType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  EtaSeconds: ").Append(EtaSeconds).Append("\n");
            sb.Append("  IsValidEstimate: ").Append(IsValidEstimate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Eta)obj);
        }
        public bool Equals(Eta other)
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
                    EtaSeconds == other.EtaSeconds ||
                    EtaSeconds != null &&
                    EtaSeconds.Equals(other.EtaSeconds)
                ) && 
                (
                    IsValidEstimate == other.IsValidEstimate ||
                    IsValidEstimate != null &&
                    IsValidEstimate.Equals(other.IsValidEstimate)
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
                    if (EtaSeconds != null)
                    hashCode = hashCode * 59 + EtaSeconds.GetHashCode();
                    if (IsValidEstimate != null)
                    hashCode = hashCode * 59 + IsValidEstimate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Eta left, Eta right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Eta left, Eta right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

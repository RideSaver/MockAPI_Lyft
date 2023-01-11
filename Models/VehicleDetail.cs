using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    [DataContract(Name = "VehicleDetail")]
    public class VehicleDetail : IEquatable<VehicleDetail>
    {
        [DataMember(Name="make")]
        public string? Make { get; set; }

        [DataMember(Name="model")]
        public string? Model { get; set; }

        [DataMember(Name="year")]
        public int? Year { get; set; }

        [DataMember(Name= "license_plate")]
        public string? LicensePlate { get; set; }

        [DataMember(Name= "license_plate_state")]
        public string? LicensePlateState { get; set; }

        [DataMember(Name="color")]
        public string? Color { get; set; }

        [DataMember(Name= "image_url")]
        public string ImageUrl { get; set; } = "Exempt";
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleDetail {\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  LicensePlate: ").Append(LicensePlate).Append("\n");
            sb.Append("  LicensePlateState: ").Append(LicensePlateState).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VehicleDetail)obj);
        }
        public bool Equals(VehicleDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Make == other.Make ||
                    Make != null &&
                    Make.Equals(other.Make)
                ) && 
                (
                    Model == other.Model ||
                    Model != null &&
                    Model.Equals(other.Model)
                ) && 
                (
                    Year == other.Year ||
                    Year != null &&
                    Year.Equals(other.Year)
                ) && 
                (
                    LicensePlate == other.LicensePlate ||
                    LicensePlate != null &&
                    LicensePlate.Equals(other.LicensePlate)
                ) && 
                (
                    LicensePlateState == other.LicensePlateState ||
                    LicensePlateState != null &&
                    LicensePlateState.Equals(other.LicensePlateState)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    ImageUrl == other.ImageUrl ||
                    ImageUrl != null &&
                    ImageUrl.Equals(other.ImageUrl)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Make != null)
                    hashCode = hashCode * 59 + Make.GetHashCode();
                    if (Model != null)
                    hashCode = hashCode * 59 + Model.GetHashCode();
                    if (Year != null)
                    hashCode = hashCode * 59 + Year.GetHashCode();
                    if (LicensePlate != null)
                    hashCode = hashCode * 59 + LicensePlate.GetHashCode();
                    if (LicensePlateState != null)
                    hashCode = hashCode * 59 + LicensePlateState.GetHashCode();
                    if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                    if (ImageUrl != null)
                    hashCode = hashCode * 59 + ImageUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VehicleDetail left, VehicleDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VehicleDetail left, VehicleDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

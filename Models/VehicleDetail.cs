using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    /// <summary>
    /// VehicleDetail
    /// </summary>
    [DataContract(Name = "VehicleDetail")]
    public class VehicleDetail : IEquatable<VehicleDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VehicleDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleDetail" /> class.
        /// </summary>
        /// <param name="make">The vehicle&#39;s maker.</param>
        /// <param name="model">The vehicle&#39;s model (required).</param>
        /// <param name="year">The vehicle&#39;s model year (required).</param>
        /// <param name="licensePlate">The vehicle&#39;s license plate (required).</param>
        /// <param name="licensePlateState">The vehicle&#39;s license plate state.</param>
        /// <param name="color">The vehicle&#39;s color (required).</param>
        /// <param name="imageUrl">The vehicle&#39;s image url (required).</param>
        public VehicleDetail(string make = default(string), string model = default(string), int year = default(int), string licensePlate = default(string), string licensePlateState = default(string), string color = default(string), string imageUrl = default(string))
        {
            this.Model = model;
            this.Year = year;
            this.LicensePlate = licensePlate;
            this.Color = color;
            this.ImageUrl = imageUrl;
            this.Make = make;
            this.LicensePlateState = licensePlateState;
        }

        /// <summary>
        /// The vehicle&#39;s maker
        /// </summary>
        /// <value>The vehicle&#39;s maker</value>
        [DataMember(Name = "make")]
        public string? Make { get; set; }

        /// <summary>
        /// The vehicle&#39;s model
        /// </summary>
        /// <value>The vehicle&#39;s model</value>
        [DataMember(Name = "model")]
        public string? Model { get; set; }

        /// <summary>
        /// The vehicle&#39;s model year
        /// </summary>
        /// <value>The vehicle&#39;s model year</value>
        [DataMember(Name = "year")]
        public int? Year { get; set; }

        /// <summary>
        /// The vehicle&#39;s license plate
        /// </summary>
        /// <value>The vehicle&#39;s license plate</value>
        [DataMember(Name = "license_plate")]
        public string? LicensePlate { get; set; }

        /// <summary>
        /// The vehicle&#39;s license plate state
        /// </summary>
        /// <value>The vehicle&#39;s license plate state</value>
        [DataMember(Name = "license_plate_state")]
        public string? LicensePlateState { get; set; }

        /// <summary>
        /// The vehicle&#39;s color
        /// </summary>
        /// <value>The vehicle&#39;s color</value>
        [DataMember(Name = "color")]
        public string? Color { get; set; }

        /// <summary>
        /// The vehicle&#39;s image url
        /// </summary>
        /// <value>The vehicle&#39;s image url</value>
        [DataMember(Name = "image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VehicleDetail);
        }

        /// <summary>
        /// Returns true if VehicleDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Make == input.Make ||
                    (this.Make != null &&
                    this.Make.Equals(input.Make))
                ) &&
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) &&
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) &&
                (
                    this.LicensePlate == input.LicensePlate ||
                    (this.LicensePlate != null &&
                    this.LicensePlate.Equals(input.LicensePlate))
                ) &&
                (
                    this.LicensePlateState == input.LicensePlateState ||
                    (this.LicensePlateState != null &&
                    this.LicensePlateState.Equals(input.LicensePlateState))
                ) &&
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) &&
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Make != null)
                {
                    hashCode = (hashCode * 59) + this.Make.GetHashCode();
                }
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
                if (this.LicensePlate != null)
                {
                    hashCode = (hashCode * 59) + this.LicensePlate.GetHashCode();
                }
                if (this.LicensePlateState != null)
                {
                    hashCode = (hashCode * 59) + this.LicensePlateState.GetHashCode();
                }
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

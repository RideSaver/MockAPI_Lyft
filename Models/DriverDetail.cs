using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    /// <summary>
    /// DriverDetail
    /// </summary>
    [DataContract(Name = "DriverDetail")]
    public class DriverDetail : IEquatable<DriverDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DriverDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DriverDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DriverDetail" /> class.
        /// </summary>
        /// <param name="firstName">The driver&#39;s first name (required).</param>
        /// <param name="phoneNumber">The driver&#39;s contact phone number. Must be E.164 formatted.  (required).</param>
        /// <param name="rating">The driver&#39;s rating based in 0-5 scale (required).</param>
        /// <param name="imageUrl">The driver&#39;s image url.</param>
        public DriverDetail(string firstName = default(string), string phoneNumber = default(string), string rating = default(string), string imageUrl = default(string))
        {
            this.FirstName = firstName;
            this.PhoneNumber = phoneNumber;
            this.Rating = rating;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// The driver&#39;s first name
        /// </summary>
        /// <value>The driver&#39;s first name</value>
        [DataMember(Name = "first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The driver&#39;s contact phone number. Must be E.164 formatted.
        /// </summary>
        /// <value>The driver&#39;s contact phone number. Must be E.164 formatted. </value>
        [DataMember(Name = "phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The driver&#39;s rating based in 0-5 scale
        /// </summary>
        /// <value>The driver&#39;s rating based in 0-5 scale</value>
        [DataMember(Name = "rating")]
        public string? Rating { get; set; }

        /// <summary>
        /// The driver&#39;s image url
        /// </summary>
        /// <value>The driver&#39;s image url</value>
        [DataMember(Name = "image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DriverDetail {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return this.Equals(input as DriverDetail);
        }

        /// <summary>
        /// Returns true if DriverDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DriverDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DriverDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) &&
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) &&
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
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
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.Rating != null)
                {
                    hashCode = (hashCode * 59) + this.Rating.GetHashCode();
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

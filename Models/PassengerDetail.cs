using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    [DataContract(Name = "PassengerDetail")]
    public class PassengerDetail : IEquatable<PassengerDetail>, IValidatableObject
    {
        [JsonConstructorAttribute]
        public PassengerDetail() { }

        /// <summary>
        /// The passenger&#39;s first name
        /// </summary>
        /// <value>The passenger&#39;s first name</value>
        [DataMember(Name = "first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The passenger&#39;s profile image
        /// </summary>
        /// <value>The passenger&#39;s profile image</value>
        [DataMember(Name = "image_url")]
        public string? ImageUrl { get; set; } = "Exempt";

        /// <summary>
        /// The passenger&#39;s rating
        /// </summary>
        /// <value>The passenger&#39;s rating</value>
        [DataMember(Name = "rating")]
        public string? Rating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PassengerDetail {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PassengerDetail)obj);
        }
        public bool Equals(PassengerDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return false;
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                return hashCode;
            }
        }
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
        #region Operators
#pragma warning disable 1591

        public static bool operator ==(PassengerDetail left, PassengerDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PassengerDetail left, PassengerDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

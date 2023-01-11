using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    [DataContract(Name = "DriverDetail")]
    public class DriverDetail : IEquatable<DriverDetail>
    {
        [JsonConstructorAttribute]
        protected DriverDetail() { }

        public DriverDetail(string firstName = default(string), string phoneNumber = default(string), string rating = default(string), string imageUrl = default(string))
        {
            this.FirstName = firstName;
            this.PhoneNumber = phoneNumber;
            this.Rating = rating;
            this.ImageUrl = imageUrl;
        }

        [Required]
        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        [Required]
        [DataMember(Name="phoneNumber")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataMember(Name="rating")]
        public string Rating { get; set; }

        [DataMember(Name="imageUrl")]
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DriverDetail {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DriverDetail)obj);
        }

        public bool Equals(DriverDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    PhoneNumber == other.PhoneNumber ||
                    PhoneNumber != null &&
                    PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    Rating == other.Rating ||
                    Rating != null &&
                    Rating.Equals(other.Rating)
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
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (PhoneNumber != null)
                    hashCode = hashCode * 59 + PhoneNumber.GetHashCode();
                    if (Rating != null)
                    hashCode = hashCode * 59 + Rating.GetHashCode();
                    if (ImageUrl != null)
                    hashCode = hashCode * 59 + ImageUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DriverDetail left, DriverDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DriverDetail left, DriverDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

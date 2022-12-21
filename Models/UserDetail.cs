using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 

    [DataContract]
    public class UserDetail : IEquatable<UserDetail>
    { 
        [Required]
        [DataMember(Name="first_name")]
        public string FirstName { get; set; }

        [Required]
        [DataMember(Name="image_url")]
        public string ImageUrl { get; set; }

        [Required]
        [DataMember(Name="rating")]
        public string Rating { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDetail {\n");
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
            return obj.GetType() == GetType() && Equals((UserDetail)obj);
        }
        public bool Equals(UserDetail other)
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
                    ImageUrl == other.ImageUrl ||
                    ImageUrl != null &&
                    ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    Rating == other.Rating ||
                    Rating != null &&
                    Rating.Equals(other.Rating)
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
                    if (ImageUrl != null)
                    hashCode = hashCode * 59 + ImageUrl.GetHashCode();
                    if (Rating != null)
                    hashCode = hashCode * 59 + Rating.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserDetail left, UserDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserDetail left, UserDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

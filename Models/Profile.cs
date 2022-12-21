using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class Profile : IEquatable<Profile>
    { 
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Profile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Profile)obj);
        }
        public bool Equals(Profile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Profile left, Profile right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Profile left, Profile right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

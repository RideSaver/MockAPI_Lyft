using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class RatingRequest : IEquatable<RatingRequest>
    { 
        [Required]
        [Range(1, 5)]
        [DataMember(Name="rating")]
        public int? Rating { get; set; }

        [DataMember(Name="feedback")]
        public string Feedback { get; set; }

        [DataMember(Name="tip")]
        public TipParams Tip { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RatingRequest {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RatingRequest)obj);
        }
        public bool Equals(RatingRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Rating == other.Rating ||
                    Rating != null &&
                    Rating.Equals(other.Rating)
                ) && 
                (
                    Feedback == other.Feedback ||
                    Feedback != null &&
                    Feedback.Equals(other.Feedback)
                ) && 
                (
                    Tip == other.Tip ||
                    Tip != null &&
                    Tip.Equals(other.Tip)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Rating != null)
                    hashCode = hashCode * 59 + Rating.GetHashCode();
                    if (Feedback != null)
                    hashCode = hashCode * 59 + Feedback.GetHashCode();
                    if (Tip != null)
                    hashCode = hashCode * 59 + Tip.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RatingRequest left, RatingRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RatingRequest left, RatingRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

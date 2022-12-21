using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class RideRequestError : IEquatable<RideRequestError>
    { 
        [Required]
        [DataMember(Name="error")]
        public string Error { get; set; }

        [DataMember(Name="error_detail")]
        public List<ErrorDetail> ErrorDetail { get; set; }

        [DataMember(Name="error_description")]
        public string ErrorDescription { get; set; }

        [DataMember(Name="primetime_percentage")]
        public string PrimetimePercentage { get; set; }

        [DataMember(Name="primetime_confirmation_token")]
        public string PrimetimeConfirmationToken { get; set; }

        [DataMember(Name="token_duration")]
        public string TokenDuration { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideRequestError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDetail: ").Append(ErrorDetail).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  PrimetimePercentage: ").Append(PrimetimePercentage).Append("\n");
            sb.Append("  PrimetimeConfirmationToken: ").Append(PrimetimeConfirmationToken).Append("\n");
            sb.Append("  TokenDuration: ").Append(TokenDuration).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RideRequestError)obj);
        }
        public bool Equals(RideRequestError other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error)
                ) && 
                (
                    ErrorDetail == other.ErrorDetail ||
                    ErrorDetail != null &&
                    ErrorDetail.SequenceEqual(other.ErrorDetail)
                ) && 
                (
                    ErrorDescription == other.ErrorDescription ||
                    ErrorDescription != null &&
                    ErrorDescription.Equals(other.ErrorDescription)
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
                ) && 
                (
                    TokenDuration == other.TokenDuration ||
                    TokenDuration != null &&
                    TokenDuration.Equals(other.TokenDuration)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                    if (ErrorDetail != null)
                    hashCode = hashCode * 59 + ErrorDetail.GetHashCode();
                    if (ErrorDescription != null)
                    hashCode = hashCode * 59 + ErrorDescription.GetHashCode();
                    if (PrimetimePercentage != null)
                    hashCode = hashCode * 59 + PrimetimePercentage.GetHashCode();
                    if (PrimetimeConfirmationToken != null)
                    hashCode = hashCode * 59 + PrimetimeConfirmationToken.GetHashCode();
                    if (TokenDuration != null)
                    hashCode = hashCode * 59 + TokenDuration.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RideRequestError left, RideRequestError right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RideRequestError left, RideRequestError right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

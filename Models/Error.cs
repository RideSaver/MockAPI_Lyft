using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class Error : IEquatable<Error>
    { 
        [DataMember(Name="error")]
        public string _Error { get; set; }

        [DataMember(Name="error_detail")]
        public List<ErrorDetail> ErrorDetail { get; set; }

        [DataMember(Name="error_description")]
        public string ErrorDescription { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  _Error: ").Append(_Error).Append("\n");
            sb.Append("  ErrorDetail: ").Append(ErrorDetail).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Error)obj);
        }
        public bool Equals(Error other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    _Error == other._Error ||
                    _Error != null &&
                    _Error.Equals(other._Error)
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
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (_Error != null)
                    hashCode = hashCode * 59 + _Error.GetHashCode();
                    if (ErrorDetail != null)
                    hashCode = hashCode * 59 + ErrorDetail.GetHashCode();
                    if (ErrorDescription != null)
                    hashCode = hashCode * 59 + ErrorDescription.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Error left, Error right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Error left, Error right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

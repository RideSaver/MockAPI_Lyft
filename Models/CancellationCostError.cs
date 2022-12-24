using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class CancellationCostError : CancellationCost, IEquatable<CancellationCostError>
    { 
        [DataMember(Name="error")]
        public string Error { get; set; }

        [DataMember(Name="error_detail")]
        public List<ErrorDetail> ErrorDetail { get; set; }

        [DataMember(Name="error_description")]
        public string ErrorDescription { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancellationCostError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDetail: ").Append(ErrorDetail).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CancellationCostError)obj);
        }
        public bool Equals(CancellationCostError other)
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
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CancellationCostError left, CancellationCostError right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CancellationCostError left, CancellationCostError right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

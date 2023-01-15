using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract(Name = "CancellationRequest")]
    public class CancellationRequest : IEquatable<CancellationRequest>
    { 
        [DataMember]
        public string? CancelConfirmationToken { get; set; }

        [JsonConstructor]
        public CancellationRequest(string? cancelConfirmationToken = default(string))
        {
            this.CancelConfirmationToken = cancelConfirmationToken;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancellationRequest {\n");
            sb.Append("  CancelConfirmationToken: ").Append(CancelConfirmationToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CancellationRequest)obj);
        }

        public bool Equals(CancellationRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CancelConfirmationToken == other.CancelConfirmationToken ||
                    CancelConfirmationToken != null &&
                    CancelConfirmationToken.Equals(other.CancelConfirmationToken)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (CancelConfirmationToken != null)
                    hashCode = hashCode * 59 + CancelConfirmationToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CancellationRequest left, CancellationRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CancellationRequest left, CancellationRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

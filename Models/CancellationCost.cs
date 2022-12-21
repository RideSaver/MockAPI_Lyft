using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class CancellationCost : Cost, IEquatable<CancellationCost>
    { 
        [DataMember(Name="token")]
        public string Token { get; set; }

        [DataMember(Name="token_duration")]
        public int? TokenDuration { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancellationCost {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenDuration: ").Append(TokenDuration).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CancellationCost)obj);
        }

        public bool Equals(CancellationCost other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
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
                    if (Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();
                    if (TokenDuration != null)
                    hashCode = hashCode * 59 + TokenDuration.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CancellationCost left, CancellationCost right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CancellationCost left, CancellationCost right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

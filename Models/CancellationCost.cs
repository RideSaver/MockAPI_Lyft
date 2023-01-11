using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    [DataContract(Name = "CancellationCost")]
    public class CancellationCost : Cost, IEquatable<CancellationCost>
    {
        [JsonConstructorAttribute]
        protected CancellationCost() { }
        public CancellationCost(int amount = default(int), string currency = default(string), string description = default(string), string token = default(string), int tokenDuration = default(int))
        {
            this.Amount = amount;
            this.Currency = currency;
            this.Description = description;
            this.Token = token;
            this.TokenDuration = tokenDuration;
        }

        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public int? Amount { get; set; }

        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string? Currency { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string? Description { get; set; }

        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string? Token { get; set; }

        [DataMember(Name = "token_duration", EmitDefaultValue = false)]
        public int? TokenDuration { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancellationCost {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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

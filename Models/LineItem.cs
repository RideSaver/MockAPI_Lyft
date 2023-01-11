using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    [DataContract(Name = "LineItem")]
    public class LineItem : IEquatable<LineItem>
    {
        [JsonConstructorAttribute]
        protected LineItem() { }
        public LineItem(string type = default(string), int amount = default(int), string currency = default(string))
        {
            this.Type = type;
            this.Amount = amount;
            this.Currency = currency;
        }

        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public int Amount { get; set; }

        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LineItem)obj);
        }
        public bool Equals(LineItem other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LineItem left, LineItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LineItem left, LineItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

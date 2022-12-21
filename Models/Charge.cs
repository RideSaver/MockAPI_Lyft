using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class Charge : IEquatable<Charge>
    { 
        [Required]
        [DataMember(Name="amount")]
        public int? Amount { get; set; }

        [Required]
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        [Required]
        [DataMember(Name="payment_method")]
        public string PaymentMethod { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Charge {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Charge)obj);
        }
        public bool Equals(Charge other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    PaymentMethod == other.PaymentMethod ||
                    PaymentMethod != null &&
                    PaymentMethod.Equals(other.PaymentMethod)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (PaymentMethod != null)
                    hashCode = hashCode * 59 + PaymentMethod.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Charge left, Charge right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Charge left, Charge right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

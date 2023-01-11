using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    /// <summary>
    /// Cost
    /// </summary>
    [DataContract(Name = "Cost")]
    public class Cost : IEquatable<Cost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Cost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Cost" /> class.
        /// </summary>
        /// <param name="amount">Total price of the ride (required).</param>
        /// <param name="currency">The ISO 4217 currency code for the amount (e.g. USD) (required).</param>
        /// <param name="description">The description for the cost (required).</param>
        public Cost(int amount = default(int), string currency = default(string), string description = default(string))
        {
            this.Amount = amount;
            this.Currency = currency;
            this.Description = description;
        }

        /// <summary>
        /// Total price of the ride
        /// </summary>
        /// <value>Total price of the ride</value>
        [DataMember(Name = "amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// The ISO 4217 currency code for the amount (e.g. USD)
        /// </summary>
        /// <value>The ISO 4217 currency code for the amount (e.g. USD)</value>
        [DataMember(Name = "currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// The description for the cost
        /// </summary>
        /// <value>The description for the cost</value>
        [DataMember(Name = "description")]
        public string? Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Cost {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Cost);
        }

        /// <summary>
        /// Returns true if Cost instances are equal
        /// </summary>
        /// <param name="input">Instance of Cost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cost input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) &&
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    /// <summary>
    /// CancellationCost
    /// </summary>
    [DataContract(Name = "CancellationCost")]
    public class CancellationCost : IEquatable<CancellationCost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationCost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancellationCost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationCost" /> class.
        /// </summary>
        /// <param name="amount">Total price of the ride (required).</param>
        /// <param name="currency">The ISO 4217 currency code for the amount (e.g. USD) (required).</param>
        /// <param name="description">The description for the cost (required).</param>
        /// <param name="token">Token used to confirm the fee when cancelling a request.</param>
        /// <param name="tokenDuration">How long, in seconds, before the token expires.</param>
        public CancellationCost(int amount = default(int), string currency = default(string), string description = default(string), string token = default(string), int tokenDuration = default(int))
        {
            this.Amount = amount;
            this.Currency = currency;
            this.Description = description;
            this.Token = token;
            this.TokenDuration = tokenDuration;
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
        /// Token used to confirm the fee when cancelling a request
        /// </summary>
        /// <value>Token used to confirm the fee when cancelling a request</value>
        [DataMember(Name = "token")]
        public string? Token { get; set; }

        /// <summary>
        /// How long, in seconds, before the token expires
        /// </summary>
        /// <value>How long, in seconds, before the token expires</value>
        [DataMember(Name = "token_duration")]
        public int? TokenDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
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
            return this.Equals(input as CancellationCost);
        }

        /// <summary>
        /// Returns true if CancellationCost instances are equal
        /// </summary>
        /// <param name="input">Instance of CancellationCost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancellationCost input)
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
                ) &&
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) &&
                (
                    this.TokenDuration == input.TokenDuration ||
                    this.TokenDuration.Equals(input.TokenDuration)
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
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenDuration.GetHashCode();
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
            // TokenDuration (int) minimum
            if (this.TokenDuration < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenDuration, must be a value greater than or equal to 0.", new[] { "TokenDuration" });
            }

            yield break;
        }
    }

}

using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    [DataContract(Name = "LineItem")]
    public class LineItem : IEquatable<LineItem>
    {
            /// <summary>
            /// Initializes a new instance of the <see cref="LineItem" /> class.
            /// </summary>
            [JsonConstructorAttribute]
            protected LineItem() { }
            /// <summary>
            /// Initializes a new instance of the <see cref="LineItem" /> class.
            /// </summary>
            /// <param name="type">The line item display name for a charge item (required).</param>
            /// <param name="amount">The line item amount (required).</param>
            /// <param name="currency">The currency for the amount (required).</param>
            public LineItem(string type = default(string), int amount = default(int), string currency = default(string))
            {
                // to ensure "type" is required (not null)
                if (type == null)
                {
                    throw new ArgumentNullException("type is a required property for LineItem and cannot be null");
                }
                this.Type = type;
                this.Amount = amount;
                // to ensure "currency" is required (not null)
                if (currency == null)
                {
                    throw new ArgumentNullException("currency is a required property for LineItem and cannot be null");
                }
                this.Currency = currency;
            }

            /// <summary>
            /// The line item display name for a charge item
            /// </summary>
            /// <value>The line item display name for a charge item</value>
            [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
            public string Type { get; set; }

            /// <summary>
            /// The line item amount
            /// </summary>
            /// <value>The line item amount</value>
            [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
            public int Amount { get; set; }

            /// <summary>
            /// The currency for the amount
            /// </summary>
            /// <value>The currency for the amount</value>
            [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
            public string Currency { get; set; }

            /// <summary>
            /// Returns the string presentation of the object
            /// </summary>
            /// <returns>String presentation of the object</returns>
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

            /// <summary>
            /// Returns the JSON string presentation of the object
            /// </summary>
            /// <returns>JSON string presentation of the object</returns>
            public virtual string ToJson()
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
                return this.Equals(input as LineItem);
            }

            /// <summary>
            /// Returns true if LineItem instances are equal
            /// </summary>
            /// <param name="input">Instance of LineItem to be compared</param>
            /// <returns>Boolean</returns>
            public bool Equals(LineItem input)
            {
                if (input == null)
                {
                    return false;
                }
                return
                    (
                        this.Type == input.Type ||
                        (this.Type != null &&
                        this.Type.Equals(input.Type))
                    ) &&
                    (
                        this.Amount == input.Amount ||
                        this.Amount.Equals(input.Amount)
                    ) &&
                    (
                        this.Currency == input.Currency ||
                        (this.Currency != null &&
                        this.Currency.Equals(input.Currency))
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
                    if (this.Type != null)
                    {
                        hashCode = (hashCode * 59) + this.Type.GetHashCode();
                    }
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                    if (this.Currency != null)
                    {
                        hashCode = (hashCode * 59) + this.Currency.GetHashCode();
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

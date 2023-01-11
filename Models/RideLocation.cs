using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace LyftAPI.Models
{
    /// <summary>
    /// RideLocation
    /// </summary>
    [DataContract(Name = "RideLocation")]
    public partial class RideLocation : IEquatable<RideLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RideLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RideLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RideLocation" /> class.
        /// </summary>
        /// <param name="lat">The latitude component of a location (required).</param>
        /// <param name="lng">The longitude component of a location (required).</param>
        /// <param name="address">A human readable address at/near the given location.</param>
        /// <param name="etaSeconds">Estimated seconds for a driver to pickup or reach destination based on ride state.</param>
        public RideLocation(double lat = default(double), double lng = default(double), string address = default(string), int etaSeconds = default(int))
        {
            this.Lat = lat;
            this.Lng = lng;
            this.Address = address;
            this.EtaSeconds = etaSeconds;
        }

        /// <summary>
        /// The latitude component of a location
        /// </summary>
        /// <value>The latitude component of a location</value>
        [DataMember(Name = "lat", IsRequired = true, EmitDefaultValue = true)]
        public double Lat { get; set; }

        /// <summary>
        /// The longitude component of a location
        /// </summary>
        /// <value>The longitude component of a location</value>
        [DataMember(Name = "lng", IsRequired = true, EmitDefaultValue = true)]
        public double Lng { get; set; }

        /// <summary>
        /// A human readable address at/near the given location
        /// </summary>
        /// <value>A human readable address at/near the given location</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Estimated seconds for a driver to pickup or reach destination based on ride state
        /// </summary>
        /// <value>Estimated seconds for a driver to pickup or reach destination based on ride state</value>
        [DataMember(Name = "eta_seconds", EmitDefaultValue = false)]
        public int EtaSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RideLocation {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  EtaSeconds: ").Append(EtaSeconds).Append("\n");
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
            return this.Equals(input as RideLocation);
        }

        /// <summary>
        /// Returns true if RideLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of RideLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RideLocation input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Lat == input.Lat ||
                    this.Lat.Equals(input.Lat)
                ) &&
                (
                    this.Lng == input.Lng ||
                    this.Lng.Equals(input.Lng)
                ) &&
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.EtaSeconds == input.EtaSeconds ||
                    this.EtaSeconds.Equals(input.EtaSeconds)
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
                hashCode = (hashCode * 59) + this.Lat.GetHashCode();
                hashCode = (hashCode * 59) + this.Lng.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EtaSeconds.GetHashCode();
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

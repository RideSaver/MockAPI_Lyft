using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    [DataContract(Name = "PickupDropoffLocation")]
    public class PickupDropoffLocation : IEquatable<PickupDropoffLocation>
    {
        [JsonConstructorAttribute]
        protected PickupDropoffLocation() { }
        public PickupDropoffLocation(double lat = default(double), double lng = default(double), string address = default(string), DateTimeOffset time = default(DateTimeOffset))
        {
            this.Lat = lat;
            this.Lng = lng;
            this.Address = address;
            this.Time = time;
        }

        [DataMember(Name = "lat", IsRequired = true, EmitDefaultValue = true)]
        public double Lat { get; set; }

        [DataMember(Name = "lng", IsRequired = true, EmitDefaultValue = true)]
        public double Lng { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTimeOffset Time { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PickupDropoffLocation {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PickupDropoffLocation)obj);
        }
        public bool Equals(PickupDropoffLocation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PickupDropoffLocation left, PickupDropoffLocation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PickupDropoffLocation left, PickupDropoffLocation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

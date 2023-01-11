using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{
    [DataContract(Name = "RideLocation")]
    public class RideLocation : IEquatable<RideLocation>
    {
        [DataMember(Name = "lat")]
        public double Lat { get; set; }

        [DataMember(Name = "lng")]
        public double Lng { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "eta_seconds")]
        public int? EtaSeconds { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RideLocation {\n");
            sb.Append("  EtaSeconds: ").Append(EtaSeconds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RideLocation)obj);
        }
        public bool Equals(RideLocation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EtaSeconds == other.EtaSeconds ||
                    EtaSeconds != null &&
                    EtaSeconds.Equals(other.EtaSeconds)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (EtaSeconds != null)
                    hashCode = hashCode * 59 + EtaSeconds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RideLocation left, RideLocation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RideLocation left, RideLocation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

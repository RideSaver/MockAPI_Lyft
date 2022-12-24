using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class PassengerDetail : UserDetail, IEquatable<PassengerDetail>
    { 
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PassengerDetail {\n");
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
            return obj.GetType() == GetType() && Equals((PassengerDetail)obj);
        }
        public bool Equals(PassengerDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return false;
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PassengerDetail left, PassengerDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PassengerDetail left, PassengerDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

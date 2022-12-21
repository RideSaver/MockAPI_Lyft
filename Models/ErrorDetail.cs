using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [DataContract]
    public class ErrorDetail : IEquatable<ErrorDetail>
    { 

        [DataMember(Name="field_name")]
        public string FieldName { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorDetail {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ErrorDetail)obj);
        }
        public bool Equals(ErrorDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FieldName == other.FieldName ||
                    FieldName != null &&
                    FieldName.Equals(other.FieldName)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (FieldName != null)
                    hashCode = hashCode * 59 + FieldName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ErrorDetail left, ErrorDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ErrorDetail left, ErrorDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RideTypeEnum
    {
        [EnumMember(Value = "lyft")]
        LyftEnum = 0,
        [EnumMember(Value = "lyft_line")]
        LyftLineEnum = 1,
        [EnumMember(Value = "lyft_plus")]
        LyftPlusEnum = 2,
        [EnumMember(Value = "lyft_suv")]
        LyftSuvEnum = 3
    }
}

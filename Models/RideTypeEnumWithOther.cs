using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LyftAPI.Models
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RideTypeEnumWithOther
        {
            [EnumMember(Value = "lyft")]
            LyftEnum = 0,
            [EnumMember(Value = "lyft_line")]
            LyftLineEnum = 1,
            [EnumMember(Value = "lyft_plus")]
            LyftPlusEnum = 2,
            [EnumMember(Value = "lyft_suv")]
            LyftSuvEnum = 3,
            [EnumMember(Value = "other")]
            OtherEnum = 4
        }
}

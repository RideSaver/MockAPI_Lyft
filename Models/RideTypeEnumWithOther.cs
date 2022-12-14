/*
 * Lyft API
 *
 * Drive your app to success with Lyft's API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: api-support@lyft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;

namespace LyftAPI.Models
{ 

        [System.Text.Json.Serialization.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

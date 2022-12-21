using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LyftAPI.Models
{ 
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum RideStatusEnum
        {
            [EnumMember(Value = "pending")]
            PendingEnum = 0,
            [EnumMember(Value = "accepted")]
            AcceptedEnum = 1,
            [EnumMember(Value = "arrived")]
            ArrivedEnum = 2,
            [EnumMember(Value = "pickedUp")]
            PickedUpEnum = 3,
            [EnumMember(Value = "droppedOff")]
            DroppedOffEnum = 4,
            [EnumMember(Value = "canceled")]
            CanceledEnum = 5,
            [EnumMember(Value = "unknown")]
            UnknownEnum = 6
        }
}

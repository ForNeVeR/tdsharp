using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class MessageContent : Object
        {
            public class MessageVideoNote : MessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messageVideoNote";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_note")]
                public VideoNote VideoNote { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_viewed")]
                public bool IsViewed { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_secret")]
                public bool IsSecret { get; set; }
            }
        }
    }
}
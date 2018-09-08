using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InlineQueryResult : Object
        {
            public class InlineQueryResultVenue : InlineQueryResult
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "inlineQueryResultVenue";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("venue")]
                public Venue Venue { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public PhotoSize Thumbnail { get; set; }
            }
        }
    }
}
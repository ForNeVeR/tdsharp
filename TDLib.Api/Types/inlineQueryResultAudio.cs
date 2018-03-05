using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InlineQueryResult : Structure
    {

        public partial class inlineQueryResultAudio : InlineQueryResult
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inlineQueryResultAudio";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("audio")]
                public Audio.audio audio_;

        }

    }

}
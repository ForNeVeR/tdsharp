using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class FoundMessages : Structure
    {

        public partial class foundMessages : FoundMessages
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "foundMessages";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("messages")]
                public Message.message[] messages_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("next_from_search_id")]
                public string next_from_search_id_;

        }

    }

}
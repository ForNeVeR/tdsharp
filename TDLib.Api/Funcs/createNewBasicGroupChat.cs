using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class createNewBasicGroupChat : Method<Chat>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "createNewBasicGroupChat";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_ids")]
                public int[] user_ids_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

        }

    }

}
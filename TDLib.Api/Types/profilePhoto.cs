using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ProfilePhoto : Structure
    {

        public partial class profilePhoto : ProfilePhoto
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "profilePhoto";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("small")]
                public File.file small_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("big")]
                public File.file big_;

        }

    }

}
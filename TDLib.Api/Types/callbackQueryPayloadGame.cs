using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class CallbackQueryPayload : Structure
    {

        public class CallbackQueryPayloadGame : CallbackQueryPayload
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "callbackQueryPayloadGame";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("game_short_name")]
                public string GameShortName { get; set; }

        }

    }

}

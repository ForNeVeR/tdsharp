using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetAuthorizationState : Method<AuthorizationState>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getAuthorizationState";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}

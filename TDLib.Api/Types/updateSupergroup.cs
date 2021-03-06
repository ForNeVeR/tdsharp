using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateSupergroup : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateSupergroup";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup")]
                public Supergroup Supergroup { get; set; }

        }

    }

}

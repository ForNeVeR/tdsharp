using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PaymentsProviderStripe : Structure
    {

        public partial class paymentsProviderStripe : PaymentsProviderStripe
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "paymentsProviderStripe";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("publishable_key")]
                public string publishable_key_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_country")]
                public bool? need_country_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_postal_code")]
                public bool? need_postal_code_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_cardholder_name")]
                public bool? need_cardholder_name_;

        }

    }

}
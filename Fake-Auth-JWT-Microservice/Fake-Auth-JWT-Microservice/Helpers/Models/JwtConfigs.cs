using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fake_Auth_JWT_Microservice.Helpers.Models
{
    public class JwtConfigs
    {
        [JsonProperty("Secret")]
        public string Secret { get; set; }

        [JsonProperty("RefreshTokenTTL")]
        public long RefreshTokenTtl { get; set; }

        [JsonProperty("OmitDaysFilter")]
        public long OmitDaysFilter { get; set; }
    }
}

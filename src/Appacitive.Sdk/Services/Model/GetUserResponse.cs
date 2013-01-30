﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Appacitive.Sdk.Services
{
    public class GetUserResponse : ApiResponse
    {
        [JsonProperty("article")]
        public User User { get; set; }

        public static GetUserResponse Parse(byte[] bytes)
        {
            IJsonSerializer serializer = ObjectFactory.Build<IJsonSerializer>();
            return serializer.Deserialize<GetUserResponse>(bytes);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Appacitive.Sdk.Services
{
    public class UpdateArticleRequest : ApiRequest
    {
        public UpdateArticleRequest() :
            this(AppacitiveContext.SessionToken, AppacitiveContext.Environment, AppacitiveContext.UserToken, AppacitiveContext.UserLocation, AppacitiveContext.EnableDebugging, AppacitiveContext.Verbosity)
        {
        }

        public UpdateArticleRequest(string sessionToken, Environment environment, string userToken = null, Geocode location = null, bool enableDebugging = false, Verbosity verbosity = Verbosity.Info) :
            base(sessionToken, environment, userToken, location, enableDebugging, verbosity)
        {
            this.PropertyUpdates = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            this.AttributeUpdates = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            this.AddedTags = new List<string>();
            this.RemovedTags = new List<string>();
        }

        [JsonIgnore]
        public string Id { get; set; }

        [JsonIgnore]
        public string Type { get; set; }

        [JsonIgnore]
        public IDictionary<string, string> PropertyUpdates { get; private set; }

        [JsonIgnore]
        public IDictionary<string, string> AttributeUpdates { get; private set; }

        [JsonIgnore]
        public List<string> AddedTags { get; private set; }

        [JsonIgnore]
        public List<string> RemovedTags { get; private set; }
    }
}

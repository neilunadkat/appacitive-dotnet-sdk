﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appacitive.Sdk.Services
{
    public class GetConnectionByEndpointRequest : GetOperation<GetConnectionByEndpointResponse>
    {
        public GetConnectionByEndpointRequest() :
            this(AppacitiveContext.ApiKey, AppacitiveContext.SessionToken, AppacitiveContext.Environment, AppacitiveContext.UserToken, AppacitiveContext.UserLocation, AppacitiveContext.EnableDebugging, AppacitiveContext.Verbosity)
        {
        }

        public GetConnectionByEndpointRequest(string apiKey, string sessionToken, Environment environment, string userToken = null, Geocode location = null, bool enableDebugging = false, Verbosity verbosity = Verbosity.Info) :
            base(apiKey, sessionToken, environment, userToken, location, enableDebugging, verbosity)
        {
        }

        public string Relation { get; set; }

        public string ArticleId1 { get; set; }

        public string ArticleId2 { get; set; }

        protected override string GetUrl()
        {
            return Urls.For.GetConnectionByEndpointAsync(this.Relation, this.ArticleId1, this.ArticleId2, this.CurrentLocation, this.DebugEnabled, this.Verbosity, this.Fields);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appacitive.Sdk.Services
{
    public class FindConnectedArticlesRequest : GetOperation<FindConnectedArticlesResponse>
    {
        public FindConnectedArticlesRequest() :
            this(AppacitiveContext.ApiKey, AppacitiveContext.SessionToken, AppacitiveContext.Environment, AppacitiveContext.UserToken, AppacitiveContext.UserLocation, AppacitiveContext.EnableDebugging, AppacitiveContext.Verbosity)
        {
        }

        public FindConnectedArticlesRequest(string apiKey, string sessionToken, Environment environment, string userToken = null, Geocode location = null, bool enableDebugging = false, Verbosity verbosity = Verbosity.Info) :
            base(apiKey, sessionToken, environment, userToken, location, enableDebugging, verbosity)
        {
        }

        public string Relation { get; set; }

        public string ArticleId { get; set; }

        public string Label { get; set; }

        public string Query { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        protected override string GetUrl()
        {
            return Urls.For.FindConnectedArticles(this.Relation, this.ArticleId, this.Label, this.Query, this.PageNumber, this.PageSize, this.CurrentLocation, this.DebugEnabled, this.Verbosity, this.Fields);
        }
    }
}

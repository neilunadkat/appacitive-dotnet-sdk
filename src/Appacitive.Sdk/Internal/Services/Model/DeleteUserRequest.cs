﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appacitive.Sdk.Services
{
    public class DeleteUserRequest : DeleteOperation<DeleteUserResponse>
    {
        public DeleteUserRequest() :
            this(AppacitiveContext.ApiKey, AppacitiveContext.SessionToken, AppacitiveContext.Environment, AppacitiveContext.UserToken, AppacitiveContext.UserLocation, AppacitiveContext.EnableDebugging, AppacitiveContext.Verbosity)
        {
        }

        public DeleteUserRequest(string apiKey, string sessionToken, Environment environment, string userToken = null, Geocode location = null, bool enableDebugging = false, Verbosity verbosity = Verbosity.Info) :
            base(apiKey, sessionToken, environment, userToken, location, enableDebugging, verbosity)
        {
            this.UserIdType = string.Empty; // Nikhil: String.empty indicates default type is id. This should probably be changed.
        }

        public bool DeleteConnections { get; set; }

        public string UserIdType { get; set; }

        public string UserId { get; set; }

        protected override string GetUrl()
        {
            return Urls.For.DeleteUser(this.UserId, this.UserIdType, this.DeleteConnections, this.CurrentLocation, this.DebugEnabled, this.Verbosity, this.Fields);
        }
    }
}

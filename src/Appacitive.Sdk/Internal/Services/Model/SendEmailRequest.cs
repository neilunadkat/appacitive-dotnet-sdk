﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Appacitive.Sdk.Realtime;


namespace Appacitive.Sdk.Services
{
    public class SendEmailRequest : PostOperation<SendEmailResponse>
    {
        public SendEmailRequest() :
            this(AppacitiveContext.ApiKey, AppacitiveContext.SessionToken, AppacitiveContext.Environment, AppacitiveContext.UserToken, AppacitiveContext.UserLocation, AppacitiveContext.EnableDebugging, AppacitiveContext.Verbosity)
        {   
        }

        public SendEmailRequest(string apiKey, string sessionToken, Environment environment, string userToken = null, Geocode location = null, bool enableDebugging = false, Verbosity verbosity = Verbosity.Info) :
            base(apiKey, sessionToken, environment, userToken, location, enableDebugging, verbosity)
        {   
        }

        public Email Email { get; set; }

        public override byte[] ToBytes()
        {
            var serializer = ObjectFactory.Build<IJsonSerializer>();
            return serializer.Serialize(this.Email);
        }

        protected override string GetUrl()
        {
            return Urls.For.SendEmail(this.CurrentLocation, this.DebugEnabled, this.Verbosity, this.Fields);
        }
    }
}

﻿using Appacitive.Sdk.Realtime;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appacitive.Sdk.Services
{
    [JsonConverter(typeof(StatusResponseConverter<BulkDeleteArticleResponse>))]
    public class BulkDeleteArticleResponse : ApiResponse
    {   
    }
}

using Sitecore.Pipelines.HttpRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.AkamaiUtils.Pipelines
{
    public class AddTestHeaders : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            HttpContext.Current.Request.Headers.Add("X-Akamai-Edgescape", "georegion=175,country_code=PL,city=WARSAW,lat=52.25,long=21.00,timezone=GMT+1,continent=EU,throughput=vhigh,bw=5000,asnum=47273,location_id=0");
            HttpContext.Current.Request.Headers.Add("X-Akamai-Device-Characteristics", "brand_name=Firefox;device_os=Windows NT;is_mobile=false");
        }
    }
}
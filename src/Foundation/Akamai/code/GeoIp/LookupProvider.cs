using Sitecore.Analytics.Lookups;
using Sitecore.Analytics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.Akamai.GeoIp
{
    public class LookupProvider : LookupProviderBase
    {
        private Dictionary<string, string> _dictionary;

        public override WhoIsInformation GetInformationByIp(string ip)
        {
            //IP doesn't matter here, but it is present in LookupProviderBase definition
            var information = new WhoIsInformation();
            if (HttpContext.Current != null &&
                HttpContext.Current.Request != null)
            {
                if(!string.IsNullOrEmpty(HttpContext.Current.Request.Headers[Const.HeaderNames.GeoIP]))
                {
                    var headerValue = HttpContext.Current.Request.Headers[Const.HeaderNames.GeoIP];
                    if (!string.IsNullOrEmpty(headerValue))
                    {
                        _dictionary = headerValue.ParseAkamaiHeader();
                        FillInforation(information);
                    }
                    return information;
                }
                Sitecore.Diagnostics.Log.Error("X-Akamai-Edgescape header is not present, please configure Akamain in proper way: https://community.akamai.com/customers/s/article/Content-Targeting-a-basic-introduction?language=en_US", this);
                return null;
            }
            Sitecore.Diagnostics.Log.Error("Foundation.Akamai.GeoIp.GetInformationByIp was called from thread where HttpContext.Current is not present", this);
            return null;
        }

        private void FillInforation(WhoIsInformation information)
        {
            information.Country = _dictionary.ContainsKey(Const.GeoIpProperties.CountryCode) ? _dictionary[Const.GeoIpProperties.CountryCode] : "";
            information.Region = _dictionary.ContainsKey(Const.GeoIpProperties.GeoRegion) ? _dictionary[Const.GeoIpProperties.GeoRegion] : "";
            information.City = _dictionary.ContainsKey(Const.GeoIpProperties.City) ? _dictionary[Const.GeoIpProperties.City] : "";
            information.AreaCode = _dictionary.ContainsKey(Const.GeoIpProperties.AreaCode) ? _dictionary[Const.GeoIpProperties.AreaCode] : "";
            information.PostalCode = _dictionary.ContainsKey(Const.GeoIpProperties.Zip) ? _dictionary[Const.GeoIpProperties.Zip] : "";
            information.Isp = _dictionary.ContainsKey(Const.GeoIpProperties.Network) ? _dictionary[Const.GeoIpProperties.Network] : "";

            string latitude = _dictionary.ContainsKey(Const.GeoIpProperties.Latitude) ? _dictionary[Const.GeoIpProperties.Latitude] : "";
            double.TryParse(latitude, out double doubleLatitude);
            information.Latitude = doubleLatitude;

            string longitude = _dictionary.ContainsKey(Const.GeoIpProperties.Longitude) ? _dictionary[Const.GeoIpProperties.Longitude] : "";
            double.TryParse(longitude, out double doubleLongitude);
            information.Longitude = doubleLongitude;
        }
    }
}
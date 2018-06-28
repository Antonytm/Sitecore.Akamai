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
            var headerValue = HttpContext.Current.Request.Headers["X-Akamai-Edgescape"];
            if (!string.IsNullOrEmpty(headerValue))
            {
                _dictionary = headerValue.ParseAkamaiHeader();
                FillInforation(information);
            }
            return information;
        }

        private void FillInforation(WhoIsInformation information)
        {
            information.Country = _dictionary.ContainsKey("country_code") ? _dictionary["country_code"] : "";
            information.Region = _dictionary.ContainsKey("region_code") ? _dictionary["region_code"] : "";
            information.City = _dictionary.ContainsKey("city") ? _dictionary["city"] : "";
            information.AreaCode = _dictionary.ContainsKey("areacode") ? _dictionary["areacode"] : "";
            information.PostalCode = _dictionary.ContainsKey("zip") ? _dictionary["zip"] : "";
            information.Isp = _dictionary.ContainsKey("network") ? _dictionary["network"] : "";

            string latitude = _dictionary.ContainsKey("lat") ? _dictionary["lat"] : "";
            double.TryParse(latitude, out double doubleLatitude);
            information.Latitude = doubleLatitude;

            string longitude = _dictionary.ContainsKey("long") ? _dictionary["long"] : "";
            double.TryParse(longitude, out double doubleLongitude);
            information.Longitude = doubleLongitude;
        }
    }
}
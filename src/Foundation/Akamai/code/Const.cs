namespace Foundation.Akamai
{
    public static class Const
    {
        public static class HeaderNames
        {
            public const string GeoIP = "X-Akamai-Edgescape";
            public const string DeviceDetection = "X-Akamai-Device-Characteristics";
        }

        public static class DeviceDetectionProperties
        {
            public const string BrandName = "brand_name";
            public const string DeviceOS = "device_os";
            public const string IsMobile = "is_mobile";
            public const string IsTablet = "is_tablet";
        }

        public static class GeoIpProperties
        {
            public const string GeoRegion = "georegion";
            public const string CountryCode = "country_code";
            public const string City = "city";
            public const string Latitude = "lat";
            public const string Longitude = "long";
            public const string Timezone = "timezone";
            public const string Continent = "continent";
            public const string Throughput = "throughput"; //actual connection speed
            public const string Bw = "bw"; // ==1 if IPv6
            public const string Ansum = "asnum"; //number or numbers that the IP belongs to(multiple values possible)
            public const string LocationId = "location_id";
            public const string AreaCode = "areacode";
            public const string Zip = "zip";
            public const string Network = "network";
            public const string Company = "company";
        }
    }
}
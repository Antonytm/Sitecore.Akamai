namespace Foundation.Akamai
{
    public static class Const
    {
        public static class HeaderNames
        {
            /// <summary>
            /// https://control.akamai.com/dl/customers/ESCAPE/EdgeScape_users_guide.pdf
            /// </summary>
            public const string GeoIP = "X-Akamai-Edgescape";
            /// <summary>
            /// More details at https://learn.akamai.com/pdf/DeviceCharacterization-CS.pdf
            /// </summary>
            public const string DeviceDetection = "X-Akamai-Device-Characteristics";
        }


        /// <summary>
        /// More details at https://learn.akamai.com/pdf/DeviceCharacterization-CS.pdf
        /// </summary>
        public static class DeviceDetectionProperties
        {
            /// <summary>
            /// The requesting devices's brand name (Google/iOS)
            /// </summary>
            public const string BrandName = "brand_name";
            /// <summary>
            /// The requesting devices's OS
            /// </summary>
            public const string DeviceOS = "device_os";
            /// <summary>
            /// Indicates if the device is a mobile
            /// </summary>
            public const string IsMobile = "is_mobile";
            /// <summary>
            /// Indicates if the device is a tablet, this is a subset of mobile device.
            /// </summary>
            public const string IsTablet = "is_tablet";
            /// <summary>
            /// The width of the screen, measured in pixels.
            /// </summary>
            public const string ResolutionWidth = "resolution_width";
            /// <summary>
            /// The width of the screen, measured in millimeters.
            /// </summary>
            public const string PhysicalScreenWidth = "physical_screen_width";
            /// <summary>
            /// The maximum width, in pixels, for an image to be viewable when the page renders in a mobile-optimized format.
            /// </summary>
            public const string MaxImageWidth = "max_image_width";
            /// <summary>
            /// The requesting browser's OS version.
            /// </summary>
            public const string MobileBrowserVersion = "mobile_browser_version";
            /// <summary>
            /// The requesting devices's OS version
            /// </summary>
            public const string DeviceOsVersion = "device_os_version";
            /// <summary>
            /// The device model's commercial name.
            /// </summary>
            public const string MarketingName = "marketing_name";
            /// <summary>
            /// Indicates if the device is a mobile device.
            /// </summary>
            public const string IsWirelessDevice = "is_wireless_device";
        }

        /// <summary>
        /// More details at https://control.akamai.com/dl/customers/ESCAPE/EdgeScape_users_guide.pdf
        /// </summary>
        public static class GeoIpProperties
        {
            /// <summary>
            /// Geo region identifier
            /// </summary>
            public const string GeoRegion = "georegion";
            /// <summary>
            /// The country_code value is an ISO-3166, two-letter code for the country where the IP address maps to.
            /// </summary>
            public const string CountryCode = "country_code";
            /// <summary>
            /// The city value is the city (within a 50-mile radius) that the IP address maps to.
            /// </summary>
            public const string City = "city";
            /// <summary>
            /// The lat value is the latitude that the IP address maps to 
            /// </summary>
            public const string Latitude = "lat";
            /// <summary>
            /// The long value is the longitude that the IP address maps to
            /// </summary>
            public const string Longitude = "long";
            /// <summary>
            /// The timezone value is the time zone that the IP address maps to
            /// </summary>
            public const string Timezone = "timezone";
            /// <summary>
            /// The continent value is a two-letter code for the continent that the IP address maps to.
            /// </summary>
            public const string Continent = "continent";
            /// <summary>
            /// The throughput is the actual connection speed that the IP address maps to.Note: This attribute will always be set to low for IPv6 addresses.
            /// </summary>
            public const string Throughput = "throughput";
            /// <summary>
            /// Provides additional granularity to the ‘throughput’ field. Note: This attribute will always be set to 1 for IPv6 addresses.
            /// </summary>
            public const string Bw = "bw";
            /// <summary>
            /// The asnum value will be the AS number or numbers that the IP belongs to(multiple values possible)            /// </summary>
            public const string Ansum = "asnum";
            /// <summary>
            /// Location identifier
            /// </summary>
            public const string LocationId = "location_id";
            /// <summary>
            /// The areacode value is the area code that the IP address maps to (multiple values possible)
            /// </summary>
            public const string AreaCode = "areacode";
            /// <summary>
            /// The zipcode value is the zipcode that the IP address maps to (multiple values possible)
            /// </summary>
            public const string Zip = "zip";
            /// <summary>
            /// The network value will be the network that the IP address belongs to.
            /// </summary>
            public const string Network = "network";
            /// <summary>
            /// The company value will be the company that the IP address belongs to.
            /// </summary>
            public const string Company = "company";
        }
    }
}
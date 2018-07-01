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
    }
}
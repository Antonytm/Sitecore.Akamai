namespace Foundation.Akamai.GeoIp
{
    public class HeaderParser : Akamai.HeaderParser
    {
        protected override string GetHeaderName()
        {
            return Const.HeaderNames.GeoIP;
        }
    }
}
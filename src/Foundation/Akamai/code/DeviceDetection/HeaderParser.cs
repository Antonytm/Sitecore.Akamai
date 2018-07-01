using Sitecore.Diagnostics;
using System.Collections.Generic;

namespace Foundation.Akamai.DeviceDetection
{
    public class HeaderParser : Akamai.HeaderParser
    {
        public override Dictionary<string, string> GetValuesDictionary()
        {
            var dictinary = base.GetHeader().ParseAkamaiHeader(";");
            Assert.IsNotNull(dictinary, "Could not parse Akamai headers");
            return dictinary;
        }

        protected override string GetHeaderName()
        {
            return Const.HeaderNames.DeviceDetection;
        }
    }
}
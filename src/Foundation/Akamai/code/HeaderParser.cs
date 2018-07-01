using Sitecore.Diagnostics;
using System.Collections.Generic;
using System.Web;

namespace Foundation.Akamai
{
    public abstract class HeaderParser
    {
        protected abstract string GetHeaderName();

        protected string GetHeader()
        {
            Assert.IsNotNullOrEmpty(HttpContext.Current.Request.Headers[this.GetHeaderName()], "Akamai header {0} is null or empty", this.GetHeaderName());
            return HttpContext.Current.Request.Headers[this.GetHeaderName()];
        }

        public virtual Dictionary<string, string> GetValuesDictionary()
        {
            var dictinary = this.GetHeader().ParseAkamaiHeader();
            Assert.IsNotNull(dictinary, "Could not parse Akamai headers");
            return dictinary;
        }

        public string GetStringValue(string property)
        {
            Assert.IsNotNullOrEmpty(property, "Property name is null or empty");
            Assert.IsNotNullOrEmpty(this.GetValuesDictionary()[property], "Property is null or empty");
            return this.GetValuesDictionary()[property];
        }

        public bool GetBoolValue(string property)
        {
            bool.TryParse(this.GetStringValue(property), out bool value);
            return value;
        }

        public int GetIntValue(string property)
        {
            int.TryParse(this.GetStringValue(property), out int value);
            return value;
        }

        public decimal GetDecimalValue(string property)
        {
            decimal.TryParse(this.GetStringValue(property), out decimal value);
            return value;
        }
    }
}
using System;
using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;

namespace Foundation.Akamai.GeoIp.Rules.Conditions
{
    public class ContinentCondition<T> : StringOperatorCondition<T> where T : RuleContext
    {
        public string Value
        {
            get;
            set;
        }

        private HeaderParser HeaderParser => new HeaderParser();

        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            return HeaderParser.GetStringValue(Const.GeoIpProperties.Continent).Equals(Value, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
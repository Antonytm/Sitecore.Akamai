using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;

namespace Foundation.Akamai.GeoIp.Rules.Conditions
{
    public class LatitudeCondition<T> : IntegerComparisonCondition<T> where T : RuleContext
    {
        private HeaderParser HeaderParser => new HeaderParser();

        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            var valueToCompare = HeaderParser.GetStringValue(Const.GeoIpProperties.Latitude);
            return base.Compare(int.Parse(valueToCompare));
        }
    }
}
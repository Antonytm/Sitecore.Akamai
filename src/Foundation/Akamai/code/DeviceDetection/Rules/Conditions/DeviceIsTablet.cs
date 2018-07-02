using Sitecore.Diagnostics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;

namespace Foundation.Akamai.DeviceDetection.Rules.Conditions
{
    public class DeviceIsTablet<T> : OperatorCondition<T> where T : RuleContext
    {
        private HeaderParser HeaderParser
        {
            get
            {
                return new HeaderParser();
            }
        }

        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            return HeaderParser.GetBoolValue(Const.DeviceDetectionProperties.IsTablet);
        }
    }
}
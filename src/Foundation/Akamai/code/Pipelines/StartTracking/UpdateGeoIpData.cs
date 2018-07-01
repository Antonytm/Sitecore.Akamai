using Foundation.Akamai.GeoIp;
using Sitecore.Analytics.Pipelines.CommitSession;

namespace Foundation.Akamai.Pipelines
{
    public class UpdateGeoIpData 
    {
        public void Process(object args)
        {
            var whois = new LookupProvider().GetInformationByIp("");
            if(whois!=null)
            {
                Sitecore.Analytics.Tracker.Current.Interaction.SetGeoData(whois);
            }
        }
    }
}
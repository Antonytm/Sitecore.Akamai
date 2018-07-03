# Sitecore.Akamai

[![Build status](https://ci.appveyor.com/api/projects/status/1c9cpp38yavc6c51?svg=true)](https://ci.appveyor.com/project/Antonytm/sitecore-akamai)




### Device Rules
* Device Is Mobile
* Device Is Tablet

### GeoIp Rules
* City
* Continent: [list of continents](docs/continentCodes.csv)
* Country code: [list of country codes](docs/cc2continent.csv)
* Latitude
* Longitude
* Timezone: [list of timezones](docs/timezone.md)

## Development environment setup

To develop and test you need to have headers added by Akamai. But will have Akamai headers only if you hosts on Akamai.
To have ability develop locally was created Sitecore.Akamai.Utils project. You need to copy assembly and configuration to your website folder. It adds Akamai headers to all your request.

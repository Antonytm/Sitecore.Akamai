# Sitecore.Akamai

[![Build status](https://ci.appveyor.com/api/projects/status/1c9cpp38yavc6c51?svg=true)](https://ci.appveyor.com/project/Antonytm/sitecore-akamai)

[![](https://sonarcloud.io/api/project_badges/quality_gate?project=Sitecore.Akamai)](https://sonarcloud.io/dashboard/index/Sitecore.Akamai)

[![](https://sonarcloud.io/api/project_badges/measure?project=Sitecore.Akamai&metric=coverage)](https://sonarcloud.io/component_measures?id=Sitecore.Akamai&metric=coverage)
[![](https://sonarcloud.io/api/project_badges/measure?project=Sitecore.Akamai&metric=code_smells)](https://sonarcloud.io/component_measures?id=Sitecore.Akamai&metric=code_smells) 
[![](https://sonarcloud.io/api/project_badges/measure?project=Sitecore.Akamai&metric=bugs)](https://sonarcloud.io/component_measures?id=Sitecore.Akamai&metric=bugs)
[![](https://sonarcloud.io/api/project_badges/measure?project=Sitecore.Akamai&metric=vulnerabilities)](https://sonarcloud.io/project/issues?id=Sitecore.Akamai&resolved=false&types=VULNERABILITY)

### Purpose of module:
Utilize features of Akamai CDN on Sitecore project

### Description
When you hosts your Sitecore project under Akamai CDN(content delivery network) you can configure Akamai to provide you X-Akamai-Edgescape and X-Akamai-Device-Characteristics. This headers will contain information about visitor location and device. Parsing of this headers can give you more abilities to personalize content on Sitecore.

## Available features

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

## Additional materials
[Sitecore and Akamai Hidden Gems, Part 1: GeoIp Detection](http://sitecorevn.blogspot.com/2018/07/sitecore-and-akamai-hidden-gems-part-1.html)

[Sitecore and Akamai Hidden Gems, Part 2: Device Detection](http://sitecorevn.blogspot.com/2018/07/sitecore-and-akamai-hidden-gems-part-2.html)

[Few words about CI on this project](https://sitecorevn.blogspot.com/2018/08/it-is-copy-of-my-article-placed-in.html)

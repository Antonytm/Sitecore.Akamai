$version = $env:APPVEYOR_BUILD_VERSION
if ($version -eq $null) {
    $version = "1.0.0"
}
"Package version: " + $version

Remove-Item build\package -Recurse -ErrorAction Ignore
New-Item -Name build\package -ItemType directory
New-Item -Name build\package\bin -ItemType directory
New-Item -Name build\package\App_Config\Include\Foundation -ItemType directory
Copy-Item .\src\Foundation\Akamai\code\bin\Foundation.Akamai* .\build\package\bin
Copy-Item .\src\Foundation\Akamai\code\App_Config\Include\Foundation\Foundation.Sitecore.Akamai.config .\build\package\App_Config\Include\Foundation
$packageCmd = "Sitecore.Courier.Runner.exe -t build\package -o build\sitecore.akamai." + $version + ".update -r"
iex $packageCmd
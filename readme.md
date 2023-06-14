# SPA + BFF sample

In this repository you can find a simple ASP.NET Core BFF that serves an angular spa too. 

This web applicates uses Auth0 to authenticate users. If you want to run this sample, configure Auth0 as described in this article.

Next, make sure to fill in the auth0 related appsettings in the following appsettings.json files:

- [Api/appsettings.json](https://github.com/appie2go/dotnet-spa-and-bff/blob/master/Api/appsettings.json)
- [SpaAndBff/appsettings.json](https://github.com/appie2go/dotnet-spa-and-bff/blob/master/SpaAndBff/appsettings.json)

After you have configured the Api and the SpaAndBff project, open the solution with Visual Studio and run both projects.
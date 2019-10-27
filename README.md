# Share ASP.NET Identity between different verisons of ASP.NET (.NET Framework, .NET Core)

## Overview

This repository shows, how it is possible to have multiple different ASP.NET application  use a shared ASP.NET Identity data store.

This repository uses the following versions:
- ASP.NET Web Application, .NET Framework 4.8, MVC
- ASP.NET Web Application, .NET Framework 4.8, SPA
- ASP.NET Web Application, .NET Framework Core 2.2, MVC
- ASP.NET Web Application, .NET Framework Core 3.0, Angular
- ASP.NET Web Application, .NET Framework Core 3.0, MVC


All of this projects point to the same ASP.NET Identity data store:
- data Source=(localdb)\mssqllocaldb
- Initial Catalog=IdentitySideBySide

## Prepare the database

To prepare the database check out the following migration SQL migration scripts:
- migration-step-1-create-db-dotnetframework.v2.2.sql
- migration-step-2-update-db-dotnetcore.v2.2.sql
- migration-step-3-update-db-dotnetcore.v3.0.sql
- migration-step-90-data.sql

When migrating data from Identity v2, make sure that the value in ````dbo.AspNetUsers.NormalizedUserName```` is filled with an uppercase value:

    UPDATE dbo.AspNetUsers SET NormalizedUserName = UPPER(UserName);

Otherewise you cannot validate the passwort in Identity v3.

## Prepare the code in ASP.NET Core

To be able to use both version (Identity v2 and Identity v3) side by side you need to set the CompatibilityMode to Versoin 2 in ````Startup.cs````:

    services.Configure<PasswordHasherOptions>(options => options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2);



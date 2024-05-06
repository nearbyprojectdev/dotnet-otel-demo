### Issue
```
Microsoft (R) Build Engine version 17.0.1+b177f8fa7 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error : ERROR: ld.so: object '/opt/datadog/apm/inject/launcher.preload.so' from /etc/ld.so.preload cannot be preloaded (cannot open shared object file): ignored. [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error : Error: [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error :   An assembly specified in the application dependencies manifest (OpenTelemetry.AutoInstrumentation.AdditionalDeps.deps.json) was not found: [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error :     package: 'Microsoft.Extensions.Configuration', version: '8.0.0' [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error :     path: 'lib/net8.0/Microsoft.Extensions.Configuration.dll' [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]

Build FAILED.

/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error : ERROR: ld.so: object '/opt/datadog/apm/inject/launcher.preload.so' from /etc/ld.so.preload cannot be preloaded (cannot open shared object file): ignored. [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error : Error: [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error :   An assembly specified in the application dependencies manifest (OpenTelemetry.AutoInstrumentation.AdditionalDeps.deps.json) was not found: [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error :     package: 'Microsoft.Extensions.Configuration', version: '8.0.0' [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
/usr/lib/dotnet/sdk/6.0.127/Roslyn/Microsoft.CSharp.Core.targets(75,5): error :     path: 'lib/net8.0/Microsoft.Extensions.Configuration.dll' [/home/keval/codebase/nearbyprojectdev/dotnet-demo-mssql/Demo-WebApplication/Mw-WebApplication.csproj]
    0 Warning(s)
    5 Error(s)

Time Elapsed 00:00:22.06
```


### Steps to Reproduce Issue

```
curl -sSfL https://github.com/open-telemetry/opentelemetry-dotnet-instrumentation/releases/download/v1.4.0/otel-dotnet-auto-install.sh -O
```
```
sh ./otel-dotnet-auto-install.sh
```

```
chmod +x $HOME/.otel-dotnet-auto/instrument.sh
```

```
dotnet restore
```

```
dotnet build
```

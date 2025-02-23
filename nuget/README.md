# DoesNuGetWork: Simple NuGet integration test

It is an empty package used for one-time connectivity test on the _NuGet_ registry

## Start: PowerShell

```PowerShell
Uninstall-Package LukeYoo.DoesNuGetWork
    # ... NuGet installation process: did it go well?

Install-Package LukeYoo.DoesNuGetWork
    # Remove it. May retry later.
```

## Start: FreeBSD, Linux, or macOS

```sh
dotnet add package LukeYoo.DoesNuGetWork
    # ... NuGet installation process: did it go well?

dotnet remove package LukeYoo.DoesNuGetWork
    # Remove it. May retry later.
```
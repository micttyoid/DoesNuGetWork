# DoesNuGetWork: Simple NuGet integration test

[NuGet Gallery](https://www.nuget.org/packages/LukeYoo.DoesNuGetWork)

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

## Upload

1. Pack
    ```
    $ dotnet pack -c Release -o .
    $ mv ./LukeYoo.DoesNuGetWork.*.nupkg ~/Desktop/
    ```

2. Upload at the NuGet Website
- Go to: https://www.nuget.org/packages/manage/upload
- Drop(Upload) from _Desktop_
- Submit

## References

[Add README](https://devblogs.microsoft.com/nuget/add-a-readme-to-your-nuget-package/#add-a-readme-to-your-package)

[NuGet Practice](https://learn.microsoft.com/en-us/nuget/create-packages/package-authoring-best-practices)

[Properties for .csproj](https://learn.microsoft.com/en-us/nuget/reference/msbuild-targets)

[XUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)
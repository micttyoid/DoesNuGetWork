# DoesNuGetWork: One-time NuGet integration test

[Package](https://www.nuget.org/packages/LukeYoo.DoesNuGetWork)

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

[CSProj Properties](https://learn.microsoft.com/en-us/nuget/reference/msbuild-targets)
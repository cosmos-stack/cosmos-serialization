@echo off

echo =======================================================================
echo Cosmos.Serialization
echo =======================================================================

::go to parent folder
cd ..

::create nuget_packages
if not exist nuget_packages (
    md nuget_packages
    echo Created nuget_packages folder.
)

::clear nuget_packages
for /R "nuget_packages" %%s in (*) do (
    del "%%s"
)
echo Cleaned up all nuget packages.
echo.

::start to package all projects
dotnet pack src/Cosmos.serialization.Xml            -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Jil            -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Lit            -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Nett           -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.serialization.Bssom          -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.serialization.Binary         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.serialization.SpanJson       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Utf8Json       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.FastJson       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Protobuf       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.SharpYaml      -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.KoobooJson     -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.YamlDotNet     -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.MsgPackCli     -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.MessagePack    -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.SwifterJson    -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.ZeroFormatter  -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.MicrosoftJson  -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.NewtonsoftJson -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.SwifterMsgPack -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do (
::    dotnet nuget push "%%s" -s "Beta" --skip-duplicate --no-symbols
    dotnet nuget push "%%s" -s "Beta" --skip-duplicate
    echo.
)

::get back to build folder
cd scripts
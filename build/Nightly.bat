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
dotnet pack src/Cosmos.serialization.Xml/Cosmos.serialization.Xml.csproj                       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Jil/Cosmos.Serialization.Jil.csproj                       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Lit/Cosmos.Serialization.Lit.csproj                       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Nett/Cosmos.Serialization.Nett.csproj                     -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.serialization.Bssom/Cosmos.serialization.Bssom.csproj                   -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.serialization.Binary/Cosmos.serialization.Binary.csproj                 -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Utf8Json/Cosmos.Serialization.Utf8Json.csproj             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.FastJson/Cosmos.Serialization.FastJson.csproj             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.Protobuf/Cosmos.Serialization.Protobuf.csproj             -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.SharpYaml/Cosmos.Serialization.SharpYaml.csproj           -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.KoobooJson/Cosmos.Serialization.KoobooJson.csproj         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.YamlDotNet/Cosmos.Serialization.YamlDotNet.csproj         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.MsgPackCli/Cosmos.Serialization.MsgPackCli.csproj         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.MessagePack/Cosmos.Serialization.MessagePack.csproj       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.SwifterJson/Cosmos.Serialization.SwifterJson.csproj       -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.ZeroFormatter/Cosmos.Serialization.ZeroFormatter.csproj   -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.MicrosoftJson/Cosmos.Serialization.MicrosoftJson.csproj   -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.NewtonsoftJson/Cosmos.Serialization.NewtonsoftJson.csproj -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.Serialization.SwifterMsgPack/Cosmos.Serialization.SwifterMsgPack.csproj -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do (
    dotnet nuget push "%%s" -s "Nightly" --skip-duplicate
	echo.
)

::get back to build folder
cd build --no-restore --no-restore
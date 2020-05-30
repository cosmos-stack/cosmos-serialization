@echo off

::create nuget_pub
if not exist nuget_pub (
    md nuget_pub
)

::clear nuget_pub
for /R "nuget_pub" %%s in (*) do (
    del %%s
)

set /p key=input key:

dotnet pack src/Cosmos.serialization.Xml -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.Jil -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.Lit -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.Nett -c Release -o nuget_pub
dotnet pack src/Cosmos.serialization.Binary -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.Swifter -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.Utf8Json -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.Protobuf -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.SharpYaml -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.KoobooJson -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.YamlDotNet -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.MsgPackCli -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.MessagePack -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.ZeroFormatter -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.MicrosoftJson -c Release -o nuget_pub
dotnet pack src/Cosmos.Serialization.NewtonsoftJson -c Release -o nuget_pub

for /R "nuget_pub" %%s in (*symbols.nupkg) do (
    del %%s
)

echo.
echo.

set source=https://api.nuget.org/v3/index.json

for /R "nuget_pub" %%s in (*.nupkg) do ( 
    call nuget push %%s %key% -Source %source%	
	echo.
)

pause
FROM mcr.microsoft.com/dotnet/runtime:2.1
COPY bin/Release/netcoreapp2.1/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "trivia_app.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:7.0
LABEL version="1.0.2" description="Aplicacao .NET Core MVC Exemplo"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "mvc1.dll"]
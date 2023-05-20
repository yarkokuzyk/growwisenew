FROM mcr.microsoft.com/dotnet/core/sdk:2.0
WORKDIR /app
COPY . .
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
ENTRYPOINT ["dotnet","WebAppProject.dll"]
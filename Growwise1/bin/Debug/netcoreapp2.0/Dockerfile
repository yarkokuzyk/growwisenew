# Використовуйте офіційний базовий образ ASP.NET Core 2.0
FROM mcr.microsoft.com/dotnet/core/sdk:2.0 AS build

# Встановлення директорії робочої області
WORKDIR /app

# Копіюємо файли проекту в контейнер
COPY . ./

# Виконуємо збірку проекту
RUN dotnet restore
RUN dotnet build --configuration Release --no-restore

# Виконуємо публікацію проекту
RUN dotnet publish --configuration Release --no-build --output /app/publish

# Фінальний образ
FROM mcr.microsoft.com/dotnet/core/aspnet:2.0

# Встановлюємо робочу директорію для контейнера
WORKDIR /app

# Копіюємо вихідні файли публікації в контейнер
COPY --from=build /app/publish .

# Запускаємо додаток
ENTRYPOINT ["dotnet", "Growwise1.dll"]
hi
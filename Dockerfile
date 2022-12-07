FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

COPY *.sln .
COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out
	
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .

# For future reference if I change the ENTRYPOINT to ["ls", "."] it will check the correct dll file
ENTRYPOINT [ "dotnet", "TrailService.dll" ] 

# FROM microsoft/dotnet:2.1-sdk AS build
# WORKDIR /app
# EXPOSE 80

# #Copy csproj and restore as distinct layers
# COPY *.csproj ./
# RUN dotnet restore

# RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq curl git nano
# RUN curl -sL https://deb.nodesource.com/setup_8.x | bash - && apt-get install -yq nodejs build-essential
# RUN npm install -g npm

# # Copy everything else and build
# COPY . ./
# RUN dotnet publish -c Release -o out

# # Build runtime image
# FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime

# WORKDIR /app

# COPY --from=build /app/out .

# ENTRYPOINT ["dotnet", "recipie-hub.dll"]

#***********************************************************************

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM dotnetnode AS build
WORKDIR /src
COPY RecipieHub.Web/RecipieHub.csproj .
RUN dotnet restore 

COPY . .
RUN dotnet build  RecipieHub.Web/RecipieHub.csproj -c Release -o /app

FROM build as publish
RUN dotnet publish RecipieHub.Web/RecipieHub.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RecipieHub.dll"]
#["dotnet", "recipie-hub.dll"]

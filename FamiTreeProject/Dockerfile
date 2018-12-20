FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY FamiTreeProject/FamiTreeProject.csproj FamiTreeProject/
RUN dotnet restore FamiTreeProject/FamiTreeProject.csproj
COPY . .
WORKDIR /src/FamiTreeProject
RUN dotnet build FamiTreeProject.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FamiTreeProject.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FamiTreeProject.dll"]

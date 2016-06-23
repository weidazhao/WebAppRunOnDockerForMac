FROM microsoft/dotnet:1.0.0-preview1
WORKDIR /app
ENTRYPOINT ["dotnet", "run"]
COPY project.json .
RUN  dotnet restore && dotnet build
COPY . .
FROM microsoft/dotnet:1.0.0-preview1
WORKDIR /app
ENTRYPOINT ["dotnet", "run"]
COPY HelloMvc/project.json .
RUN dotnet restore
COPY HelloMvc/ .
RUN dotnet build
FROM mcr.microsoft.com/dotnet/sdk:6.0

ENV DOTNET_USE_POLLING_FILE_WATCHER 1
ENV DOTNET_RUNNING_IN_CONTAINER 'true'

WORKDIR /src

RUN dotnet dev-certs https

ENTRYPOINT dotnet watch run --urls=https://+:5001 --project "Mango.Web.csproj"
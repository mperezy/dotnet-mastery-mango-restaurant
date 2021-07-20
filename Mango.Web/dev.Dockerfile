FROM mcr.microsoft.com/dotnet/sdk:6.0

ENV DOTNET_USE_POLLING_FILE_WATCHER 1
ENV DOTNET_RUNNING_IN_CONTAINER 'true'

WORKDIR /src

RUN apt-get update && \
apt-get install iputils-ping -y &&\
apt-get install lsof -y

RUN dotnet dev-certs https

EXPOSE 50962

ENTRYPOINT dotnet watch run --urls=http://+:5000 --project "Mango.Web.csproj"
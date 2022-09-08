FROM mcr.microsoft.com/dotnet/sdk:6.0

ENV DOTNET_USE_POLLING_FILE_WATCHER 1
ENV DOTNET_RUNNING_IN_CONTAINER 'true'

WORKDIR /src

RUN apt-get update && \
apt-get install iputils-ping -y &&\
apt-get install lsof -y

RUN dotnet dev-certs https
RUN dotnet tool install --global dotnet-ef --version 6.0.0-preview.6.21352.1

ENV PATH="${PATH}:/root/.dotnet/tools"

ENTRYPOINT dotnet watch run --urls=http://+:5000 --project "Mango.Services.ProductAPI.csproj"
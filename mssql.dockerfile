FROM mcr.microsoft.com/mssql/server:2019-CU3-ubuntu-18.04

USER root
# Install depedencies and mssql-cli
RUN apt-get update && \
apt-get install curl -y && \
apt-get install software-properties-common -y && \
curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add - && \
apt-add-repository https://packages.microsoft.com/ubuntu/18.04/prod && \
apt-get update && \
apt-get install mssql-cli -y && \
apt-get install -f

VOLUME /docker/sqlserver-data /var/opt/mssql

WORKDIR /var/opt/mssql

# To connect to server
# mssql-cli -S <server name> -U <user name> -d <database name>

# To check sql server version
# mssql-cli -S localhost -U sa -Q 'select @@VERSION'
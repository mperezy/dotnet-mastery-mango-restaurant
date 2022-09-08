# .NET Master Mango Restaurant

This repo contains the whole project written step by step following the Udemy course [.NET Core Microservices - The Complete Guide (.NET 6 MVC)](https://www.udemy.com/course/net-core-microservices-the-complete-guide-net-6-mvc) and was built using **docker** and **docker-compose**.

---
## Requirements
- .NET Framework 6.0 (just for syntax in code editor)
- Have docker and docker-compose installed (Linux/macOS)
- Visual Studio, Visual Code or Rider/DataGrip (these last from JetBrains, needs a subscription to use)

## Environment variables
- Copy the file `.env.example` with `.env` name, and replace the inside values with the required environment values.

## How to run
- Only need to pull this repo and run the next to get all the container up and running:
```console
$ docker-compose up
```
- Now we should be able to run the each app using the [**https://locahost:PORT**](#) in our browser, the port could be found in [docker-compose](docker-compose.yml) file.
- API apss use swagger to check the enpoints and test them, for that you will need to follow [**https://localhost:api_port/swagger/index.html**](#)

## Execute commands
- If we want to make migrations or some commands inside on some container, you should run:
```console
$ docker exec -it conainer_name bash
```
```console
root@product-api:/src dotnet ef database update
Build started...
Build succeeded.
Done.

root@product-api:/src dotnet ef migrations add SeedProducts
Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
```

Have fun !
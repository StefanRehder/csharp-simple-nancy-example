# Simple RESTful Web Service implemented with .NET 4.6 and NancyFx
This is a simple lightweight RESTful web service implemented with .NET and NancyFx. 
The example web service exposes a number of operations that can be used to handle hero objects stored in memory.
The web service exposes the same operations as [dotnetcore-simple-nancy-example](https://github.com/StefanRehder/dotnetcore-simple-nancy-example) but the version in this repository can only run on Windows computers.

## Requirements

- [Microsoft Visual Studio (recommended but not required)](https://visualstudio.microsoft.com/) 
- [.NET 4.6 Framework (included with Visual Studio so no need to install both)](http://go.microsoft.com/fwlink/?LinkId=528259)

## Getting Started
Build and run the application from Visual Studio (or build from command line with [Microsoft Build Tools](http://www.microsoft.com/en-us/download/details.aspx?id=48159) and execute the output exe file). When the web service is running, navigate to http://localhost:8210/ in a web browser for further details.

## Swagger Documentation
The web service documentation is generated with Nancy.Swagger and can be viewed with Swagger-ui like this:
1. Run the application
2. Go to [http://petstore.swagger.io/](http://petstore.swagger.io/)
3. Type http://localhost:8210/api-docs
4. Click "Explore"
5. Enjoy the Swagger documentation for the web service

Play around with the running web service with curl or Postman.
e.g. `curl -X PUT http://localhost:8210/hero -H 'Content-Type: application/json' -v -d '{ "name": "Robin", "strength": 1 }'`

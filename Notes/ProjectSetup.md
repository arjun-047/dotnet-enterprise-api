# Project Setup

## commands Used
mkdir src
cd src
mkdir Server
cd Server
dotnet new sln -n EnterpriseAPI

dotnet new classlib -n EnterpriseAPI.Domain
dotnet new classlib -n EnterpriseAPI.Application
dotnet new classlib -n EnterpriseAPI.Infrastructure
dotnet new webapi -n EnterpriseAPI.API


## Why multiple projects?
Instead of putting everything into one project, enterprise applications split responsibilities into different projects.

Benefits:
- easier testing
- better seperation of concerns
- easier maintenance and scalability
- compiler prevents wrong dependencies

# Web API vs Class Library
## Web API

A web api project is an executable asp.net core aplication

It contains:
- Kestrel Web Server
- HTTP Middleware pipeline
- Configuration
- Logging
- Routing
- Controllers / Endpoints
- Program.cs

## Class library
a class library is a resuable DLL, cannot run by itself.

contains
- Business logic
- Entities
- Data access
- Interfaces
- DTOs
- Mappers
- Validation rules

# whats Kestrel

asp.net core builtin cross-platform web server.

- It listens for HTTP requests and forwards them to the asp.net core middleware pipeline.

- start the middleware pipeline
- return responses

without kestrel, .net core application cannot receive web requests.

## why do companies still use IIS or Nginx?
Internet ->  IIS / Nginx -> Kestrel -> ASP.NET Core Application

nginx/IIS handle concerns like:
- Reverse proxy
- load balancing
- SSL termination
- security


## Life cycle of http request
= browser/postman
= Kestrel
= Middleware pipeline
= Authentication
= Authorization
= Routing
= Controller/Endpoint
= Service
= Repository
= Database
= Response

## Things I Learned Today
- A Web API is an executable application.
- Class Libraries are reusable DLLs.
- Kestrel is the web server that runs ASP.NET Core.
- Kestrel is not replaced by IIS or Nginx.
- IIS/Nginx sit in front of Kestrel as a reverse proxy.
- Enterprise projects separate code into multiple projects to enforce architecture.


# Interview Ques

## What is kestrel?
Kestrel is ASP.net core builtin cross platform web server, it listens for http requests, runs the middleware pipeline and forwards the requests to the appropriate endpoint

## Why use IIS or Nginx if Kestrel already exists?
Kestrel execute the .net core application while nginx handle https, reverse proxy, load balancing, serve static files.

## Diff between web api and class library
a web api is an executable .net core application which handles http requests

a class library is a resuable DLL that contains code but cannot run independently.
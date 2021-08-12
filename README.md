# Engel & Völkers Digital Invest
<table>
<tr>
<td>
  EFDI_Task is a repository containing solution of 3 given tasks. Each folder contains solution of 1 task.
  Original tasks can be found in the root of the repository.
</td>
</tr>
</table>

## Sql
SQL files with queries are placed in SQL folder.
- CampaignsOfAdvertiser.sql -> show all campaigns of advertiser #100 that have more than 50
- CampaignsWithoutAds.sql -> show all campaigns that do not have any ads

## Api
In the "Api" folder located .NET solution EFDI.ApiTask.
In solution, there is one ASP.NET project that contains Ad Endpoints.
The project has swagger support.

.net 5 sdk should be installed to build the project.

To start the project in debug mode, run the following command in the folder of the solution.

<code>
dotnet run
</code>

## Application
Application code can be found in the "Application/EFDI.ApplicationTask" folder.

- EFDI.Frontend - folder with Angular 12 frontend project
- EFDI.ApplicationTask - folder with ASP.NET 5 backend project
- EFDI.ApplicationTask.Tests - Unit and Integration tests for the backend.

To run the project in debug mode, start backend with
```
dotnet run
```
command from the EFDI.ApplicationTask. By default, the backend will be hosted on 5000/5001(for HTTPS) port.

To start frontend in dev mode, run the following commands from the EFDI.Frontend folder.

```
npm i
npm start
```

The frontend uses proxy in dev mode to rewrite "/api" calls. If you want to continue to use /api routes on the non-dev environment, use a reverse proxy for backend; otherwise, you need to specify correct roots in the environment.prod config.
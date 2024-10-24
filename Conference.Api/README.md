# Conference-CloudNative Development
### Prerequisites
in linux: install docker and VSCode and Azure Data Studio on your Linux and run your SQL Server Container on it:

in Windows: install Docker Desktop and Azure Data Studio and run your SQL Server Container on it by run Powersherrl in admin mode: 
```yml
docker pull mcr.microsoft.com/mssql/server
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Str0ng@124' -p 1400:1433 -d mcr.microsoft.com/mssql/server
```

Before or after installing C# dev kit, dotNET 8 must be installed for this kit to work properly:

https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-install?pivots=os-linux-ubuntu-2404&tabs=dotnet8

To connect to the database in Linux, you need to install Azure Data Studio.

Added Migration to the project:
First, you must add the Nuget package to vscode and then install dotnet tools on your VM. Next, you must install dotnet-ef to complete the migration process:
```yml
dotnet tool install --global dotnet-ef
```
Next, we need to add the Microsoft.EntityFrameworkCore.Design package:
```yml
dotnet add package Microsoft.EntityFrameworkCore.Design
```
And finally, to perform Migration to the project:
```yml
dotnet-ef migrations add InitialMigration1
```

If you are using VisualStudio, it is easier and you just need to select Nuget Package Manager and Package Manager Console from the Tools menu and enter the following command:
```yml
add-migration InitialMigration1
```
To create tables and records according to what is in the up method in Migration, we use the following command:
```yml
dotnet-ef database update
```
In VisualStudio, it is enough to type in the Package Manager Console:
```yml
update-database
```

to Publish Conference.Api Project:
```yml
dotnet publish --os linux --arch x64 /t:PublishContainer -c Release
```

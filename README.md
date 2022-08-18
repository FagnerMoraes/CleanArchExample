# CleanArchExample

## Install project
```
https://github.com/FagnerMoraes/CleanArchExample.git
```




### Dependency install

#### .NET 5 - https://dotnet.microsoft.com/en-us/download/dotnet/5.0


how to verify .net5 is install using CLI command:
```
dotnet --list-sdks
```

Execute a Restore project:
```
dotnet restore
```
Execute a Build project:

```
dotnet build
```


##


This project use SQLServer connection, but you can change this dependecy.
You need to modify two files:



#### DependencyInjection.cs

```
services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
```
#### appsetings.json

```
"ConnectionStrings": {
    "DefaultConnection": "Data Source=YOUR PC NAME\\sqlexpress;Initial Catalog=CleanArchEampleDB; Integrated Security=True"
  },
```



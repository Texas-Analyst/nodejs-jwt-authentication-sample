# This sample project is following Les Jackson

## Docker Compose with .NET Core & SQL Server (Step-by-Step)
"https://www.bing.com/videos/search?q=YouTube+Docker+Les+Jackson&docid=608051658643275851&mid=84EDE02B090A90169A3084EDE02B090A90169A30&view=detail&FORM=VIRE"

## https://www.npgsql.org/efcore/index.html
## Postgre Dotnet Cli -- Note must useNgpSQL in Startup.cs
##  dotnet ef dbcontext scaffold "Server=localhost;User
## ID=postgres;database=colour;Port=5432;Password=^MacMachine2022^trusted_connection=true;"
## Npgsql.EntityFrameworkCore.PostgreSQL -o Models

## Startup.cs for Postgre ==>  using Npgsql;
## then Configure options.UseNpgsql(Configuration["Postgres:connectionString"]);

## Run normal migrations --> (1) run ef migrations add <MIGRATION> , then (2) dotnet ef update database
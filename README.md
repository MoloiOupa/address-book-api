# Step-by-step to run for the first time:

## Make sure EF Core tools are installed

If you haven't installed EF Core tools globally, run:

```

dotnet tool install --global dotnet-ef

```

## Create a migration (if you haven't yet)

Assuming you created your AddressBookContext and models, generate the initial migration:

```

dotnet ef migrations add InitialCreate

```

This creates migration files based on your DbContext schema.

## Apply migrations to the database

Update your database with the schema (create DB if not exists):

```

dotnet ef database update

```

## Run your application

Run your .NET Core API project (e.g.):

```

dotnet run

```

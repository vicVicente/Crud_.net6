# Crud .Net 6

To use the project, we have to run the migrations, it is who creates the tables in the database based on the models of the project, after configuring the context and making the cardinality within the project, we can start the stage of migrations.

To run the commands you must be in the same hierarchy as the .csproj file.

In CMD:

> dotnet ef

This command tells you if you have dotnet ef installed.

> dotnet ef migrations add 'name'

This command creates the migrations files, creating a file that creates the data in the database.

> dotnet ef database update

This command executes migrations, creating our database architecture, and can be used to update them.

*Don't forget to enter your MySQL username and password.*

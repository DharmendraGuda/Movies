#  Movies
Moveis API using Dotnet 5 and Unit Test

# **About Project and Running Instructions**
The solution has two projects: MoviesAPI and Movies.Tests.
This MoviesAPI  is a Dotnet5 project. It uses local DB. Execute the command "update-database" to run the migrations and seed the test data. 

# **If I have more time, I would add the below features to make the app more reliable.**
  
 Implement centralized exception handling, exception retry mechanism wherever applicable and logging framework.
 
 Implement action filter to parse and validate input, output response and return proper http response. 
 
 Repository pattern to create the abstraction over EF Context.
 
 Refactor the startup class. Rerganize dependencies and IOC.

 Implement unit testing more effectively to cover all the use cases. 
 
 Authentication/Authorization.

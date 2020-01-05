# FootballDataAPIWrapper

API Wrapper that uses the https://www.football-data.org/ API and exposes 2 GET Endpoints:

### /import-league/{leagueCode}

  Imports the competition with that code to the database, including teams and players

### /total-players/{leagueCode}

  Returns the amount of players in a competition
  
  
 ## Set Up
 
 1- Create a DB with the name FootballDataDB in your localDB
 
 2- Change the Connection String in appsettings.json (local and development)
 
 3- Use an API key from https://www.football-data.org/ and change it in the appsettings.json (local and development)
 
 4- Either run the Script "Tables Creation.sql" from FootballDataWrapper.Data/Scripts in you DB or run the migrations in the   
 "FootballDataWrapper.Data/Migrations" folder with entity framework
 
 5- Run the project
 
 ## Technologies used
  Net core 2.2
  
  Entity Framework core
  
  Dependency Injection
  
  Async Calls
  
  Swagger
  
  Automapper
  
  Linq
  
  ## Patterns: 
  Unit of Work
  
  Generic Repository
  
  N-Tier Architecture
  
  Singleton

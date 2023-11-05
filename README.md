# Summoner Scanner

___Summoner Scanner_ isn't endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or anyone officially involved in producing or managing Riot Games properties. Riot Games, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.__

# Developer Notes

# TODOS

* Continue code cleanup
  * Refactor methods so that they are more single-purpose
  * Create Classes for consistent object structures
    
* Add champion icons to player names
  * Fetch Champion Images from CDragon
  * Cache Images within the Application
  * Create a Method to fetch and display images based on the champion name
    
* Add background color for player names to signify if the player won with the player or lost with them
  * Add the reverse for the enemy team
    
* handle user input capitalization

* Create a settings box
  * Allow the user to set a default summoner name which is cached within the application
  * Allow the user to change their region
  * Allow the user to resize the window
  * Allow the user to change the default number of games to return
  * Allow the user to adjust the stats or information they want to be displayed in the allied and enemy players' lists
  * Allow the user to modify the stats and details they want to have shown on the details form.    

# Planned Features

* Redesign using Overwolf Electron
  * Detect match start events to trigger application look-up for the current game
  * using the names of the players in the current game check if any match the names on the user's lists
  * Create a setting check box to disable checking premade
    
* Integrate storing match history details as well as player stats for names on tracking lists
  * Capture match History with this player
  * capture performance stats with this player
  * capture the player's ranked stats and history
  * capture the player's champion mastery stats
  * Create UI to allow users to input and modify their notes for players
  
* implement overlay for displaying info and notes on players in your game
    
  
# Added Features

* ~~Champion played, role, and KDA to players List~~
* ~~Can view details form for each player captured on lists~~
* ~~Instructions are now adjustable and extendable~~
* ~~Note Details now parse and separates notes using commas and periods into different lines~~

# Required Setup
## API
To setup api please cd into WebScraper.Data and run "**dotnet ef database update**"

Puts the required data into database. (using sqlexpress db as requested)

## Client
To setup client please cd into WebScraper.Client and run npm install to install required dependencies

and then "**npm start**" to start the client

# WebScraper
An N-tier application divided into 3 layers -> API, Application and Data

I really like the mediator pattern so decided to use the mediatR package with CQRS pattern, this is too much for this application
but wanted to show a demonstration of separation of concern.

I used React for the frontend to design a UI for the application.

Also added in a search history functionality.

Please let me know if there are any problems!

# StockCheck

### An ASP.NET Core Web app designed to act as a donation platform for those in need during the covid 19 pandemic

# Introduction

For this term we were tasked with creating a robust covid-19 relief app that solves a current problem or current service. The concept is entirely up to us but functionally the app should feature full CRUD functionality, at least one data relationship, a database to store users, objects or other items and we must use Git for version control.

# Concept 

So something I’ve recently noticed is that a lot of people that have all of a sudden become really generous ever since the effects of coronavirus have been seen. The problem with this is that there is a disconnect between the two groups of people. People who would like to donate don't really know how they could help and people who need help don't know where they can get it. So my concept is to create a donation platform where people who want to help can create listings for items they would like to donate and people who need help can browse the listing to see if there’s anything they could use.  So my target audience will be both people who are looking to help others and people who are looking for help themselves.

# Getting started
#### Prerequisites 

You will need to have the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download) Installed as well as [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
Once you have loaded the project into visual studio do the following

2. Add the nuget package for the sql server by typing ```bash 
Install-Package Microsoft.EntityFrameworkCore.SqlServer ``` in the package manager console

3. Make sure the connection strings in appsetting.json are correct for your operating system and database type whether that be SQL, SQLite  or mySQL

4. Lastly make sure to run the migrations If needed and update the database by running this in the package managaer console **DONT FORGET THE CONTEXT**  
```bash
Add-Migration InitialCreate -Context DonoListingsContext  Update-Database
```

## Installation
Clone this repository and open the solution in **Visual Studio 2019**
```bash
git clone git@github.com:LukeRamsay/<Dono>.git
```
or

```sh
git clone https://github.com/LukeRamsay/Dono.git
```

# Features and functionality

### Core Functionality
    Users can sign up and login
    Donation listings are fully working with CRUD
    Users can see their own created listings - one to many relationship

### Additional Functionality
    Image Uploading saves to local and saves name to database
    Images can be deleted, deleted from local files and deletes from the database
    Automatically tracks the time and date when a listing is created
    Users can view their profile and update their user data

### Future Functionality
   * Searching + Filtering of listings
    * Add categories to listings
    * Google maps implementation for listing location
    * Comments on a listing
    * Bookmark a donation
    * View others profiles
    * Update Styling
  

# Built with

* .NET Core 3.1
* Entitiy Framework Core 
* C# + CSHtml
* Visual Studio 2019
* EF Core Sql Server

## Contributing

1. Fork it
2. Create your feature branch (git checkout -b my-new-feature)
3. Commit your changes (git commit -m 'Add some feature')
4. Run the linter (ruby lint.rb').
5. Push your branch (git push origin my-new-feature)
6. Create a new Pull Request

# Authors
 **Luke Ramsay** - Lazy Student

# License 
Distributed under the MIT License. See `LICENSE` for more information.

# Acknowledgements
#### Thanks to ......
* My Lecturer [Ruan](https://github.com/RuanOW) for helping me to finally understand MVC and for all the classes and recordings

*  [Microsoft .NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.1)

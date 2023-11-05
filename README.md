# _Pierre's Sweet And Savory Treats_

#### By _**Mac Granger**_

#### _This is an MVC C# application with authentication and authroization that will track treats and their flavors._

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _Razor Pages_
* _Entity Framework Core_
* _ASP.NET Core Identity_
* _Visual Studio Code_
* _Github_

## Description

_This MVC C# application whith authentication and authorization uses ASP.NET Core Identity to allow users to register and then login to add treats + flavors to Pierres Sweet and Savory treats webpage, all users can see the homepage but will not be able to alter treats or flavors until they have created an account and are logged in. The user can add flavors to treats and treats to flavors provided there are some flavors already added, this will all be stored within MySQL. Add sweet treats and savory treats, whatever your tastebuds are craving!_

## Setup/Installation Requirements

- Note: An installation of the .NET SDK is required in order to run this application 
locally. [See Here](https://dotnet.microsoft.com/en-us/) for installation.

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "PierresTreats.Solution". 
3. Navigate to the project directory: `$ cd PierresTreats`
4. Create a file named `appsettings.json`: `$ touch appsettings.json`
5. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. Replace the `database` value with the name that you wish to give the database that will back up this application. Entity will create the database for you in a subsequent step. 

    ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
      }
    }
    ```
6. Run `$ dotnet ef database update`. This command will create the database and required tables on your local machine.
7. Run `$ dotnet watch run` in the command line to start the project in development mode with a watcher.
8. Open the browser at: _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).
9. This app uses and Authentication and Authorization scheme implemented with ASP.NET Core Identity. All users are able to access the homepage and related pages for viewing data. In order to create, update or delete items, users must first register an account and login to the app.


## Known Bugs

* _No known issues_

## License

Copyright (c) 2023 Mac Granger

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
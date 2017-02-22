# Son of Cod Seafood

This project was generated with Visual Studio 2015 Community

## Prerequisites

You will need the following things properly installed on your computer.

* [Visual Studio](https://www.visualstudio.com/downloads/)

## Installation

* `git clone <https://github.com/Cmwingo/.NET-SonOfCod>` this repository
* Open the project in Visual Studio, right click on the solution folder in the solution explorer window, and select build
* From the command line, navigate to the project directory containing your project.json file
* `dotnet ef database update` to migrate the database to your local database
* You should then be able to run the project in Visual Studio

## Site Administration Instructions
* Navigate to http://localhostXXXX/account/register to register an email and password
* Then navigate to http://localhostXXXX/role/create and create a user role called 'admin'
* Finally navigate to http://localhostXXXX/role/ManageUserRoles and add your username(your email) to the 'admin' role
* You should then be able to login with that account info and access all administrator functions of the site as well as add additional users to the admin role

## Known Bugs

_No known issues at this time_

## Support and contact details

_Please feel free to contact me with questions, comments, or contributions to improve the program at cmwingo@gmail.com_

### License

*https://creativecommons.org/licenses/by-nc/3.0/us/legalcode*

Copyright (c) 2017 **_Chris Wingo_**

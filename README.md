# _Stack Underflow_

#### _Individual Project - Last Updated June 8, 2020_

#### By _**Matt Stroud**_

## Description

_Stack Underflow is a RESTful MVC web forum application built with C# and MySQL._  
_Users can register, log in, and create threads and posts._  

_This project is still in progress and is being updated regularly._

## Demo
![Screenshot of splash page](https://raw.githubusercontent.com/mlstroud/StackUnderflow/master/demo1.png)
![Screenshot of forums page](https://raw.githubusercontent.com/mlstroud/StackUnderflow/master/demo2.png)
![Screenshot of threads page](https://raw.githubusercontent.com/mlstroud/StackUnderflow/master/demo3.png)


## Specs
### User Stories
* As a user, I want to be able view all forums.
* As a user, I want to be able to view threads within a forum.
* As a user, I want to be able to view all posts within a thread.
* As a user, I want to be able to register.
* As a user, I want to be able to log in.
* As a logged in user, I want to be able to create posts.

### Behaviors


### RESTful Routing


### Stretch Goals


## Setup/Installation Requirements
> This application requires the .NETCore SDK - [Find your version here](https://dotnet.microsoft.com/download/dotnet-core/2.2)

1. Create a StackUnderflow.Solution directory.
```
mkdir StackUnderflow.Solution
```
2. Navigate inside your new directory.
```
cd StackUnderflow.Solution
```
3. Clone this repository to your directory.
```
git clone https://github.com/mlstroud/StackUnderflow.git
```
4. Setup Database - Run the MySQL commands below:
```
CREATE DATABASE `stack_underflow`;

USE `stack_underflow`;
```
5. Navigate to StackUnderflow subdirectory and create appsettings.json
```
touch appsettings.json
```
6. Paste the following text into your appsettings.json file.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=stack_underflow;uid=YOURUSERNAMEHERE;pwd=YOURPASSWORDHERE;"
  }
}
```
>NOTE: Replace the username and password with your own.
>If you choose to use your own database, update the value here and run the following MySQL commands:
```
DROP DATABASE `stack_underflow`;
CREATE DATABASE `YOUR_DATABASE_HERE`;
USE `YOUR_DATABASE_HERE`;
```
7. Apply database migrations.
```
dotnet ef database update
```
8. Run the application with the following command:
```
dotnet run
```
9. Open URL in browser:
```
http://localhost:5000/
```

## Known Bugs
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/StackUnderflow/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MVC
* MySQL
* Entity Framework Core
* RESTful Design
* Git

### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**
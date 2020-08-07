![Dr. Seuss background img](https://cdn.vox-cdn.com/thumbor/xTsXh7b3wS3tY11IfKnuinsJMFY=/59x0:939x495/1600x900/cdn.vox-cdn.com/assets/3170021/Seusville.png)
# Dr. Snuess' Factory

#### C# Friday Independant Project, 08.07.2020

## By Benjamin Russell

## Description

_This application will help a factory owner keep track of all the enginners who work in their factory and all the machines each engineer is licensed to repair. The factory owner will be able to see a list of all engineers, their details and the machines they can maintain. The owner will also be able to add new engineers when they are hired and should be able to remove engineers who no longer work there._

## Setup/Installation Requirements

* Clone this repository from GitHub https://github.com/brussell36/Factory.Solution.git
* Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
* Install [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) 
* To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
* Run dotnet restore in terminal to get all dependencies.
* Run dontnet build in terminal to make sure project has everything required and no issues.
* Run the program with the command dotnet run.

#### Additional Setup/Installation Notes:

* You will need to have MySQL installed on your computer to start the database for this project. 
* Once you have it installed open your terminal and run mysql -uroot -pepicodus. This will start the mysql server on your computer. 
* You will need to run the command dotnet ef migrations add Initial. This create a folder that holds information MySQL needs to create the database.
* Then run dotnet ef database update. This will migrate the database to MySQL workbench where you can refresh the Schemas tab to make sure everything was created properly.
* Then you will have the database correctly set up and you can start the project in a separate terminal that the one running mysql by running dotnet run.

## Specifications

| Behavior | Input | Output |
| -------- | ----- | ------ |
| 1. As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines. |  | List of all Machines and List of all Engineers |
| 2. As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it. |  | List of details for each Engineer and Machine |
| 3. As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed. | Name: Rufus, Machine Name: Dreamweaver  | Rufus' details and Dreamweaver details |
| 4. As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine. | Delete button for engineers and machines |  |
| 5. I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it. | | |

## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

Please feel free to contact me through GitHub (username: brussell36) with any questions, ideas or concerns.  

## Technologies Used

* C#
* .NET Core 2.2
* Visual Studio Code 
* Git and Git BASH 
* MySQL Workbench
* MySQL Database
* Entity Framework


### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_Benjamin Russell_**
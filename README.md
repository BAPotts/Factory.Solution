# _Dr. Sneuss's Factory_

#### _C#/.Net SQL Exercise for Epicodus, 07/31/20_

#### By _**Beverly Potts**_

## Description

_An internal database program to track relationships between machines and engineers in Dr. Sneuss's factory._

## Specifications

User Stories
As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed
As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.


## Setup/Installation Requirements


  1. Follow this [link to the project repository](https://github.com/BAPotts/Factory.Solution.git) on GitHub. 
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
   4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose "open with..." and open using a text editor such as VS Code or Atom, etc.
  8. Open the terminal inside of your text editor.
  9. From inside of the Factory directory, type the command `dotnet restore` into your terminal and hit enter. You should see object files appear. They should be greyed out.


## Database Population

To populate a database, delete the migrations folder and  run dotnet ef migrations add Initial from the Factory folder. Then run dotnet ef database update.


## Known Bugs

There are no known bugs at this time.

## Support and contact details

Feedback is greatly appreciated! Contact BAPotts on GitHub with any questions or comments.

## Technologies Used

* C# 
* .NET-Core 2.2
* Visual Studio Code
* Git Version Control 
* GitHub
* Sql Workbench 8.0

### License

*This project is licensed under the MIT license.*

Copyright (c) 2020 **_{Beverly Potts}_**
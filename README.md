# SamCooks API Documentation

### Welcome to the documentation for SamCooks API.
### This guide will help you set up the development environment, download the necessary tools, and run the application.

# Table of Contents
1. Prerequisites
2. Getting Started
3. Running the Application
4. Updating the Database

## Prerequisite
1. Before you begin, please make sure you have the following tools installed on your system:
2. [Visual Studio 2019](https://visualstudio.microsoft.com/vs/older-downloads/)
3. SQL Server 2019 or navigate to the [link](https://www.microsoft.com/en-gb/sql-server/sql-server-downloads)
4. MSSM 19 - click [Microsoft SQL management studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
   

## Getting Started
1. Clone the repository to your local machine
2. Open Visual Studio 2019.
3. In Visual Studio, navigate to File > Open > Project/Solution and select the .sln file from the cloned repository.
4. Build the solution by clicking on the Build menu and selecting Build Solution.

## Running the Application
1. Open the project in Visual Studio 2019.
2. Right-click on Samcooks.API in the Solution Explorer and select "**Set as StartUp Project**".
3. Press F5 or click on the green "Start" button to run the application. This will launch the API in your default web browser.
   ![Screenshot (125)](https://github.com/Aresprojex/SamCooks.API/assets/130857532/dd04fbe5-4566-4723-bd4e-60eae7391be9)


## Updating the Database
1. Open the Package Manager Console in Visual Studio 2019 by navigating to **Tools > NuGet Package Manager > Package Manager Console**.
2. In the Package Manager Console, ensure that the default project is set to SamCooks.API.
3. Run the following command to apply pending migrations and update the database:
   `Update-Database`
   Hit enter to enxcute this command
   This command will apply any pending migrations to the database and bring it up to date with the latest schema.
![Screenshot (123)](https://github.com/Aresprojex/SamCooks.API/assets/130857532/1653ecca-edfe-4491-85a8-aebe2f350767)

4. Open MSSM and confirm that the Database is created.
   ![Screenshot (124)](https://github.com/Aresprojex/SamCooks.API/assets/130857532/1a008686-b718-48c0-bd69-45101a88db1f)

Happy coding! 🚀




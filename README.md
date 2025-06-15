# CRUD Application - ASP.NET Core

A simple CRUD (Create, Read, Update, Delete) application built with ASP.NET Core Razor Pages and SQL Server. Manage user records (Name and Email) with a clean, responsive interface featuring Bootstrap and custom CSS.

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

## Table of Contents
- [Features](#features)
- [Screenshots](#screenshots)
- [Requirements](#requirements)
- [Setup Instructions](#setup-instructions)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Technologies](#technologies)
- [Contributing](#contributing)
- [License](#license)

 ## Features
 - **Create**: Add new users via a form.
 - **Read**: Display all users in a scrollable table.
 - **Update**: Edit existing user details.
 - **Delete**: Remove users from the database.
 - **Responsive Design**: Built with Bootstrap 4.5.2 and custom CSS.
 - **Database**: SQL Server with Entity Framework Core for data management.

## Screenshots
| Application Main Screen |
|-------------|
| ![Application Screenshot](./docs/screenshot.png) |

## Prerequisites
 - .NET 6.0 SDK
 - SQL Server Express (e.g., JOHNSLENOVOZ50\SQLEXPRESS)
 - Visual Studio 2019 or later (or VS Code with .NET CLI)
 - Git

## Setup Instructions
1. Clone the Repository:
   ```bash
   git clone https://github.com/johnkoshy/CRUD-Application-ASP.NET-Core.git
   cd CRUD-Application-ASP.NET-Core
   ```
2. Restore Dependencies:
   ```bash
   cd CRUD_APP
   dotnet restore
   ```
3. Configure Database:
   - Ensure SQL Server Express is running.
   - Update the connection string in `appsettings.json` if needed:
     ```json
     "ConnectionStrings": {
       "CRUD_APPContext": "Server=JOHNSLENOVOZ50\\SQLEXPRESS;Database=CRUD_APP;Trusted_Connection=True;TrustServerCertificate=True;"
      }
      ```
4. Apply Migrations:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
5. Run the Application:
   ```bash
   dotnet run
   - Open `https://localhost:5001` in your browser.

## Usage

1. Navigate to `https://localhost:5001` to view the user table.
2. Go to `/Create` to add a new user (enter Name and Email).
3. Click **Edit** to update a user’s details.
4. Click **Delete** to remove a user.
5. Verify data in SQL Server Management Studio (SSMS):
   ```sql
   USE CRUD_APP;
   SELECT * FROM Users; 
   ```

## Project Structure
 - **CRUD_APP.csproj**: Project file with dependencies.
 - **Pages/**: Razor Pages (`Index.cshtml`, `Create.cshtml`, etc.).
 - **wwwroot/css/site.css**: Custom styles for layout and responsive design.
 - **wwwroot/images/w.jpg**: Background image (optional).
 - **appsettings.json**: Database connection configuration.
 - **docs/**: Stores documentation, including screenshot.png.

## Technologies
 - **ASP.NET Core 6.0**: Web framework.
 - **Entity Framework Core 6.0.35**: ORM for database operations.
 - **SQL Server Express**: Database server.
 - **Bootstrap 4.5.2**: CSS framework for responsive design.
 - **jQuery 3.5.1**: JavaScript library for client-side functionality.
 - **Roboto Font**: Google Fonts for typography.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue on GitHub for suggestions or bug reports.

## License
This project is licensed under the [MIT License](LICENSE).
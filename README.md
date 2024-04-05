# Notes App

## Overview

The Notes App is a simple application for managing notes. It consists of both a backend and a frontend component. The backend is developed using C#, ASP.NET Web API (.NET 6.0) to handle multiple endpoints for CRUD (Create, Read, Update, Delete) operations on notes. The frontend is built using HTML, CSS, and JavaScript to display and interact with the notes. The notes are stored in a SQL Server database managed by SQL Server Management Studio (SSMS) locally on your system.

## Features

- **CRUD Operations:** Supports Create, Read, Update, and Delete operations on notes.
- **Multiple Endpoints:** Backend provides multiple endpoints to handle various operations on notes.
- **Database Integration:** Uses SQL Server database to store and manage notes data.
- **Responsive Design:** Frontend is designed to be responsive and user-friendly.

## Technologies Used

- Backend:
  - C#
  - ASP.NET Web API (.NET 6.0)
- Frontend:
  - HTML
  - CSS
  - JavaScript
- Database:
  - SQL Server
  - SQL Server Management Studio (SSMS)

## Setup Instructions

### Backend

1. Navigate to the `backend` folder.
2. Open the solution file in Visual Studio or your preferred C# IDE.
3. Set up your SQL Server database connection string in the `appsettings.json` file.
4. Build and run the backend application.

### Frontend

1. Navigate to the `frontend` folder.
2. Open the `index.html` file in a web browser or any web development environment.
3. Ensure the backend server is running.
4. Interact with the frontend to manage your notes.

### Database

1. Open SQL Server Management Studio (SSMS).
2. Connect to your local SQL Server instance.
3. Execute the SQL script provided in the `database_setup.sql` file to create the necessary database schema and tables.

## Folder Structure

Notes-App/
│
├── backend/ # Backend codebase
│ ├── Controllers/ # ASP.NET Web API controllers
│ ├── Models/ # Data models
│ ├── Data/ # DataBase creation File
│ ├── Migration/ # Migration folder of DataBase
│ └── appsettings.json # Configuration file
│
├── frontend/ # Frontend codebase
│ ├── index.html # HTML file for displaying notes
│ ├── style.css # CSS file for styling
│ └── script.js # JavaScript file for frontend logic
│
└── database_setup.sql # SQL script for database setup

## Contributing

Contributions are welcome! If you find any bugs or have suggestions for improvements, please feel free to open an issue or submit a pull request.

## Acknowledgements

- ASP.NET Web API
- SQL Server
- SQL Server Management Studio (SSMS)

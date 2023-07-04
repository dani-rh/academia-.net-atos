# To Do 2 Day

To Do 2 Day is a modern to-do list application. It allows users to manage their tasks efficiently and also categorize tasks using tags for better organization and productivity.

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- .NET 6.0 or later
- Node.js 18.0 or later
- Angular CLI 12.0 or later

## Getting Started

This repository contains both the frontend and backend code for To Do 2 Day.

### Backend

The backend is built using C#. Here's how to get it up and running:

1. Connect to your local database and run the migrations.
2. Open a terminal/command prompt.
3. Navigate to the backend project directory (e.g., `cd backend`).
4. Restore the .NET packages by running `dotnet restore`.
5. Build the project by running `dotnet build`.
6. Run the project by running `dotnet run`.

The backend server should now be running at `http://localhost:7097` .

You can find the swagger documentation at `https://localhost:7097/swagger/index.html`

### Frontend

The frontend is an Angular application. Follow these steps to run it:

1. Open a new terminal/command prompt.
2. Navigate to the frontend project directory (e.g., `cd frontend`).
3. Install the dependencies by running `npm install`.
4. Start the Angular app by running `ng serve`.

You can now access the frontend by opening `http://localhost:4200` in your web browser.

## License

This project is licensed under the terms of the [MIT license](./LICENSE).

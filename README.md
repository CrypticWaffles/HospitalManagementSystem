# HospitalManagementSystem
This repository contains a comprehensive Hospital Management System built with a client-server architecture. The system is designed to streamline various hospital operations, from patient and inventory management to real-time monitoring and communication. It features a C# Windows Forms client and an ASP.NET Core backend with SignalR for real-time capabilities.

## Key Features
-   **User Authentication & Authorization:** Secure login and registration system with role-based access control (Patient, Admin, Doctor, Nurse, Staff).
-   **Patient Information Management:** Full CRUD (Create, Read, Update, Delete) functionality for patient demographic data and medical histories.
-   **Appointment Scheduling:** A dedicated module for booking and managing patient appointments.
-   **Medical Inventory Control:** Track and manage medical supplies and equipment.
-   **Real-Time Dashboard:** A live dashboard powered by SignalR to monitor simulated patient vitals (Heart Rate, Blood Pressure, SpO2) and hospital-wide statistics like bed occupancy and emergencies.
-   **Live Chat:** A SignalR-based chat feature for real-time communication between users.
-   **Analytics and Reporting:** Generate detailed reports on patient data and inventory, with options to export in JSON, CSV, and XML formats.
-   **Bulk Data Import:** Utility to import patient and medical history data from CSV and JSON files.

## Architecture
The system is divided into two main projects: a Windows Forms client and an ASP.NET Core server.

-   **`HospitalManager` (Client):** A .NET Windows Forms application that serves as the user interface. It communicates with a SQL Server database for core data (patients, inventory, etc.) and a MongoDB database for user authentication. It also connects to the SignalR backend for real-time updates.

-   **`HospitalManagerServer` (Server):** An ASP.NET Core application responsible for real-time functionalities. It hosts SignalR hubs (`ChatHub` for messaging and `DashboardHub` for live data) and includes a data simulator (`PatientDataSimulator`) to broadcast dynamic patient vitals for the dashboard.

## Technologies Used
-   **Client:** C#, Windows Forms, .NET Framework 4.7.2
-   **Server:** ASP.NET Core, SignalR
-   **Databases:**
    -   Microsoft SQL Server (Patient Records, Medical History, Inventory, Appointments)
    -   MongoDB (User Accounts)
-   **Frameworks/Libraries:**
    -   Entity Framework
    -   SignalR Client
    -   Newtonsoft.Json

## Getting Started

### Prerequisites

-   Visual Studio 2022 or newer
-   .NET 8 SDK
-   .NET Framework 4.7.2
-   Microsoft SQL Server (Express or other editions)
-   MongoDB

### Installation & Setup
1.  **Clone the repository:**
    ```bash
    git clone https://github.com/CrypticWaffles/HospitalManagementSystem.git
    cd HospitalManagementSystem
    ```

2.  **Configure Databases:**
    -   Ensure your SQL Server and MongoDB instances are running.
    -   Create a SQL Server database named `HospitalManager` and the necessary tables (`Patients`, `MedicalHistories`, `MedicalInventory`, `appointments`, `users`).
    -   Create a MongoDB database named `HospitalManager` with a `users` collection. You can use the `HospitalManager.users.json` file as a reference for the user schema.

3.  **Update Connection Strings:**
    -   Open the `HospitalManager/App.config` file.
    -   Modify the `HospitalManager.Properties.Settings.HospitalManagerConnectionString` value to point to your SQL Server instance.
    -   Modify the `DatabaseConnection` value to point to your MongoDB instance.

4.  **Build and Run:**
    -   Open `HospitalManager.sln` in Visual Studio.
    -   Right-click the solution in the Solution Explorer and select "Set Startup Projects...".
    -   Choose "Multiple startup projects" and set the Action for both `HospitalManager` and `HospitalManagerServer` to "Start".
    -   Press F5 or click the "Start" button to run the application. The server will launch first, followed by the client application.

### Usage

1.  Launch the application. You will be greeted by the Start Form.
2.  Register a new user or log in with existing credentials. User roles include `Patient`, `Doctor`, `Nurse`, `Staff`, and `Admin`.
3.  Based on your role, the main Hub form will display available modules. Non-patient roles have access to administrative and management features.
4.  Navigate through the different forms to manage patients, inventory, appointments, or view real-time data on the dashboard.

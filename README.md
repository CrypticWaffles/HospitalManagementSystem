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


### SQL Setup
-- Create the database
CREATE DATABASE HospitalManager;
GO

-- Use the newly created database
USE HospitalManager;
GO

-- Create Patients table
CREATE TABLE Patients (
    PatientId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10),
    PhoneNumber NVARCHAR(15),
    Address NVARCHAR(255)
);

-- Create MedicalHistories table
CREATE TABLE MedicalHistories (
    HistoryId INT IDENTITY(1,1) PRIMARY KEY,
    PatientId INT NOT NULL,
    RecordDate DATE NOT NULL,
    Diagnosis NVARCHAR(255),
    Treatment NVARCHAR(255),
    Notes NVARCHAR(MAX),
    FOREIGN KEY (PatientId) REFERENCES Patients(PatientId) ON DELETE CASCADE
);

INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, Address)
VALUES
('John', 'Doe', '1985-03-15', 'Male', '555-1234', '123 Main St'),
('Jane', 'Smith', '1990-07-22', 'Female', '555-5678', '456 Oak Ave'),
('Michael', 'Johnson', '1978-11-03', 'Male', '555-8765', '789 Pine Rd'),
('Emily', 'Davis', '2000-02-28', 'Female', '555-3456', '321 Birch Blvd'),
('Robert', 'Brown', '1965-05-10', 'Male', '555-4321', '654 Maple Ln');

INSERT INTO MedicalHistories (PatientId, RecordDate, Diagnosis, Treatment, Notes)
VALUES
(1, '2023-05-10', 'Hypertension', 'Prescribed medication (Lisinopril)', 'Follow-up in 3 months'),
(1, '2024-01-15', 'Seasonal Allergies', 'Antihistamines', 'Symptoms worse in spring'),

(2, '2023-06-20', 'Type 2 Diabetes', 'Diet + Metformin', 'Recommended regular monitoring'),
(2, '2024-02-11', 'Flu', 'Oseltamivir', 'Recovered fully'),

(3, '2022-09-30', 'Back Pain', 'Physical Therapy', 'MRI recommended'),
(3, '2023-12-05', 'High Cholesterol', 'Statins prescribed', 'Encouraged diet changes'),

(4, '2023-10-12', 'Asthma', 'Inhaler prescribed', 'Needs regular checkups'),
(4, '2024-04-18', 'Migraines', 'Sumatriptan prescribed', 'Track frequency'),

(5, '2022-01-25', 'Arthritis', 'Pain management with NSAIDs', 'Referred to rheumatologist'),
(5, '2023-08-14', 'Skin Rash', 'Topical cream', 'Possible allergic reaction');

-- Use the newly created database
USE HospitalManager;
GO

CREATE TABLE MedicalInventory (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100) NOT NULL,
    ItemType NVARCHAR(50) NOT NULL, -- e.g., Medication, Equipment, Supply
    QuantityInStock INT NOT NULL,
    Unit NVARCHAR(20), -- e.g., tablets, bottles, boxes
    LastUpdated DATETIME NOT NULL DEFAULT GETDATE()
);

INSERT INTO MedicalInventory (ItemName, ItemType, QuantityInStock, Unit)
VALUES 
('Paracetamol 500mg', 'Medication', 150, 'Tablets'),
('Ibuprofen 200mg', 'Medication', 80, 'Tablets'),
('Syringes 5ml', 'Supply', 40, 'Units'),
('Surgical Gloves - Medium', 'Supply', 200, 'Pairs'),
('Bandages 10cm x 4m', 'Supply', 25, 'Rolls'),
('Amoxicillin 250mg', 'Medication', 10, 'Capsules'),
('IV Drip Set', 'Supply', 12, 'Sets'),
('Insulin Pen', 'Medication', 60, 'Pens'),
('Antiseptic Solution 250ml', 'Medication', 5, 'Bottles'),
('Thermometer Digital', 'Equipment', 15, 'Units');
-- Create users table
CREATE TABLE users (
    usersId INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    phone VARCHAR(20)
);

-- Create appointments table with foreign key constraint
CREATE TABLE appointments (
    appointmentId INT IDENTITY(1,1) PRIMARY KEY,
    userId INT NOT NULL,
    doctorName VARCHAR(100) NOT NULL,
    doctorSpecialty VARCHAR(100),
    startTime DATETIME NOT NULL,
    status VARCHAR(20),
    notes VARCHAR(200),
    CONSTRAINT FK_appointments_userId FOREIGN KEY (userId) REFERENCES users(usersId)
);

-- Insert users
INSERT INTO users (name, email, phone) VALUES
('Alice Johnson', 'alice@example.com', '+1234567890'),
('Bob Martinez', 'bob@example.com', '+1987654321'),
('Carla Singh', 'carla@example.com', '+1092837465');

-- Insert appointments
INSERT INTO appointments (userId, doctorName, doctorSpecialty, startTime, status, notes) VALUES
(1, 'Dr. John Smith', 'Dermatologist', '2025-06-21 10:00:00', 'booked', 'Consultation on skin rash'),
(2, 'Dr. John Smith', 'Dermatologist', '2025-06-21 11:00:00', 'booked', 'Heart checkup follow-up'),
(3, 'Dr. Emily Lee', 'Cardiologist', '2025-06-22 09:00:00', 'completed', 'Routine physical exam'),
(1, 'Dr. Ravi Patel', 'General Physician', '2025-06-23 13:00:00', 'canceled', 'General consultation');

# Tebi Akademi Student Management System

## Overview

This Windows Forms application was developed for Tebi Akademi, a private educational institution, to manage student information, attendance, and course progress. This system aims to streamline administrative tasks and provide easy access to student data for educators and administrators.

## Features

- **Student Registration**: Easily register new students with comprehensive information capture.
- **Student Listing**: View and manage a list of all registered students.
- **Attendance Tracking**: Monitor and record student attendance.
- **Course Progress Tracking**: Keep track of topics covered and exercises completed for each student.
- **Email Communication**: Send emails to students or parents directly from the application.
- **Data Search and Filtering**: Quickly find student information using search and filter functionality.

## Project Structure

The project is structured as a standard Windows Forms application with the following key components:

- `Form1.cs` & `Form2.cs`: Main application windows
- `ogrencikayit.cs`: Student registration form
- `ogrlistele.cs`: Student listing form
- `devamsizlik.cs`: Attendance tracking form
- `konuilerleme.cs`: Course progress tracking form
- `email.cs`: Email communication form

## Technologies Used

- **Language**: C#
- **Framework**: .NET Framework 4.5
- **Database**: Microsoft SQL Server Express
- **IDE**: Visual Studio 

## Setup and Installation

1. Clone the repository:
   ```
   git clone https://github.com/tebiakademi/student-management-system.git
   ```
2. Open the solution file (`WindowsFormsApplication2.sln`) in Visual Studio.
3. Restore NuGet packages if necessary.
4. Update the connection string in each form to point to your SQL Server instance:
   ```csharp
   SqlConnection baglan = new SqlConnection("Data Source=YOUR_SERVER_NAME;Initial Catalog=ogrenciotomasyon;Integrated Security=True");
   ```
5. Build and run the application.

## Database Setup

1. Create a new database named `ogrenciotomasyon` in your SQL Server instance.
2. The application will create necessary tables on first run, or you can manually create them based on the schema implied by the application code.

## Usage

1. **Student Registration**: 
   - Open the student registration form (`ogrencikayit`)
   - Fill in student details and save

2. **View Students**: 
   - Use the student listing form (`ogrlistele`) to view all registered students
   - Use search functionality to find specific students

3. **Track Attendance**: 
   - Use the attendance form (`devamsizlik`) to record student attendance

4. **Record Course Progress**: 
   - Open the course progress form (`konuilerleme`)
   - Enter details about covered topics and completed exercises for each student

5. **Send Emails**: 
   - Use the email form to send communications to students or parents

## Contributing

While this project was specifically developed for Tebi Akademi, we welcome contributions that could enhance its functionality or fix any bugs. Please follow these steps to contribute:

1. Fork the repository
2. Create a new branch (`git checkout -b feature-branch`)
3. Make your changes and commit them (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin feature-branch`)
5. Create a new Pull Request

## License

This project is proprietary software developed for Tebi Akademi. All rights reserved.

## Support

For support, please contact the IT department of Tebi Akademi or open an issue in this repository.

## Acknowledgments

- Thanks to all the staff and administrators at Tebi Akademi who provided requirements and feedback during the development process.
- Special thanks to the development team who created this system.

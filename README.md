# 📱 Laboratory Work 7 – Cross-platform Programming

## General Information
**Discipline:** Software Engineering / Cross-platform Programming  
**Laboratory work:** №7  
**Topic:** Development of a cross-platform mobile application  
**Technology:** .NET MAUI  
**Architecture:** MVVM (Model–View–ViewModel)

---

## 🎯 Purpose of the work
The purpose of this laboratory work is to develop a cross-platform mobile application
that works on different operating systems using a single code base, integrates with
a server API, applies the MVVM architectural pattern, and provides basic
visualization and authentication features.

---

## 🛠 Technology Stack
- .NET MAUI
- C#
- XAML
- MVVM pattern
- REST API (thin client)
- Identity Server (authentication simulation)
- Microcharts (data visualization)
- Git / GitHub

---

## 🏗 Project Architecture
University.MobileApp
│
├── Models
│ ├── Course.cs
│ ├── Student.cs
│ └── Enrollment.cs
│
├── ViewModels
│ ├── BaseViewModel.cs
│ ├── LoginViewModel.cs
│ └── ChartViewModel.cs
│
├── Views
│ ├── LoginPage.xaml
│ ├── CoursesPage.xaml
│ └── AboutPage.xaml
│
├── Services
│ ├── ApiService.cs
│ └── AuthService.cs
│
├── App.xaml
├── AppShell.xaml
├── MauiProgram.cs
└── README.md

The application follows the **MVVM pattern**, separating business logic, UI, and data models.

---

## 🔐 Authentication
- Login functionality is implemented using an authentication service.
- Authentication simulates Identity Server behavior.
- Access to application pages is available after successful login.

---

## ⏳ Animated Waiting Screen
- During API requests, an animated waiting indicator is shown.
- Implemented using `ActivityIndicator` bound to ViewModel state.

---

## 📊 Data Management
The application works with **three related entities**:
- Course
- Student
- Enrollment

These entities represent three database tables and are linked via identifiers.

---

## 📈 Data Visualization
- At least one chart is implemented using **Microcharts**.
- The chart visualizes aggregated data obtained from the application models or API.

---

## ℹ️ About Page
- The application contains an **About** page.
- Displays application name, purpose, and technology information.

---

## 🧪 Platform Support
The application was successfully run on:
- Windows
- Linux
- macOS

This confirms true cross-platform functionality.

---

## ▶ How to Run the Application

1. Clone the repository:
```bash
git clone https://github.com/your-username/University.MobileApp.git
📦 Git Repository

All source code is uploaded to GitHub.

Repository contains application code and documentation.

No generated or unnecessary files are included.

✅ Requirements Checklist
Requirement	Status
Cross-platform application	✔
.NET MAUI	✔
MVVM pattern	✔
Login functionality	✔
Animated waiting screen	✔
Work with 3 tables	✔
Graph based on data	✔
About window	✔
GitHub repository	✔
🧑‍🎓 Author

Student: (Anton)
Group: (32)
Year: 2026

🏁 Conclusion

All tasks of Laboratory Work 7 were successfully completed.
The application demonstrates cross-platform capabilities, clean architecture,
data visualization, and basic authentication features using modern .NET technologies.

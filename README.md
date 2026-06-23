# EF Core Learning Project

This is a simple **Entity Framework Core** project built using **.NET** and **SQL Server**.  
The goal of this project is to practice and understand the fundamentals of EF Core, including:

- Code First Approach
- Migrations
- One-to-One Relationships
- DbContext configuration
- Basic CRUD operations

---

## ⚠️ Project Status

This project is still in the **learning phase**.  
It is not a production-ready application — it is mainly used for practicing and improving my skills in EF Core and database design.

---

## 🛠️ Technologies Used

- C#
- .NET (Console Application)
- Entity Framework Core
- SQL Server
- Code First Migrations

---

## 📁 Project Structure

EFCore/
│
├── Models/
│ ├── Student.cs
│ ├── Grade.cs
│ └── Department.cs
│
├── AppDbContext.cs
├── Connections.cs
├── Program.cs
│
├── Migrations/
│ ├── StudentTable.cs
│ └── OneToOneRelation.cs

---

## 🧩 Database Models

### Student
Represents a student with basic information such as:
- Name
- Email
- Age
- Grade
- BirthDate

### Grade
Represents student grades in different subjects:
- Physics
- Chemistry
- Biology

**Relationship:**
- One-to-One relationship between `Student` and `Grade`

### Department
Simple entity for future expansion and practice.

---

## 🔗 Relationship Mapping

- Student ↔ Grade → One-to-One Relationship
- Each student has one grade record linked via `StudentId`

---

## 📌 Note

This is a learning project, and the code is continuously improving as I progress in my EF Core and .NET journey.
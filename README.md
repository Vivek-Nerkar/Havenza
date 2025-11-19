# Havenza
HAVENZA
HAVENZA is a modular, full‑stack .NET application designed with scalability, clean architecture, and accessibility in mind. It leverages modern frameworks and best practices to deliver a robust foundation for building enterprise‑grade web applications.

**📂 Project Structure
**The solution is organized into multiple projects for separation of concerns:

Havenza.Application – Application logic, use cases, and service orchestration

Havenza.Core – Domain models, business rules, and core abstractions

Havenza.Infrastructure – Data access, persistence, and external integrations

Havenza.Shared – Shared utilities, constants, and cross‑cutting concerns

Havenza.Web – ASP.NET Core web layer (UI, APIs, Blazor components)

**🚀 Features
**Modular architecture with clear boundaries

ASP.NET Core + Blazor front‑end

SQL Server integration for persistence

RESTful API design with Swagger/OpenAPI support

Responsive, accessible UI with semantic HTML + CSS

NuGet package references for modern .NET workflows

**🛠️ Getting Started
**Prerequisites
.NET 8+

SQL Server (local or remote instance)

Visual Studio 2022 / Rider / VS Code

**Installation**
Clone the repository:

bash
git clone https://github.com/Vivek-Nerkar/Havenza.git
cd Havenza
Restore dependencies:

bash
dotnet restore
Build the solution:

bash
dotnet build
Run the web project:

bash
dotnet run --project Havenza.Web
Configuration
Update appsettings.json in Havenza.Web with your database connection string.

Apply migrations (if using EF Core):

bash
dotnet ef database update --project Havenza.Infrastructure
📖 Usage
Once running, the web app will be available at: https://localhost:5001 (HTTPS) or http://localhost:5000 (HTTP)

You can explore APIs via Swagger UI at: https://localhost:5001/swagger

**🤝 Contributing
**Contributions are welcome!

Fork the repo

Create a feature branch

Submit a pull request

Please follow clean coding practices and ensure accessibility in UI components.

**📜 License
**This project is licensed under the MPL‑2.0 license. See LICENSE.txt for details.

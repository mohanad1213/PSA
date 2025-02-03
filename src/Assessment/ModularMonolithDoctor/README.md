# Modular Monolith [![license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://opensource.org/licenses/MIT) 

Folder structure 

 ```bash
├── 📦 Modular Monolith Doctor Start up       
├── 📂 Modules                
    ├── 📦Module 1: Doctor Availability (Layered Architecture)
    ├── 📦Module 2: Appointment Booking (Clean Architecture)
        ├── 📒 AppointmentBooking.API (Presentation)
        ├── 📒 AppointmentBooking.Application
            ├── ServicesAbstraction
            ├── Services
            ├── Commands
            ├── Queries
        ├── 📒 AppointmentBooking.Domain
            ├── Models (Contain Main Domain Models)
            ├── RepoAbstraction
            ├── DomainServiceAbstraction
        ├── 📒 AppointmentBooking.Infrastructure
            ├── DomainService
    ├── 📦 Module 3: Appointment Confirmation 
    ├── 📦 Module 4: Doctor Appointment Management  (Hexagonal Architecture)
        ├── 📒 DoctorAppointmentManagement.API
            ├── Shell
                ├── Ports
                    ├── ⬇️ InputPorts
                    ├── ↘️ OutputPorts
                ├── Services
            ├── Core
                ├── Adapters (Repo Implemtations)
                ├── Controller (Presentation)
                ├── ➡️ Requests
                ├── ⬅️ Responce

    ├── 📂Shared
        ├── ⛃ In-Memory Database 1 (For Module 1: Doctor Availability)
        ├── ⛃ In-Memory Database 2 
    └── README.md
``` 


this project consist of 4 modules

## 0) ModularMonolithDoctor.Startup

this project is just entry point for our api and modules



## 1) Doctor Availability module (Layered Architecture)

Using layered architecture consist of 3 layers
we use DI here as part of ASP.NET MVC .NET 8 Framework

1. Presentation Layer (API Layer client can call this layer)
2. business layer
3. data access layer

## 2) Appointment Booking (Clean Architecture)


## 3)

## 4) Doctor Appointment Management Module (Hexagonal Architecture)

## Shared 

Shared project any module can access

--

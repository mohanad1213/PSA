# Modular Monolith

this project consist of 4 modules

## 0) ModularMonolithDoctor.Startup

this project is just entry point for our api and modules



## 1) Doctor Availability module (Layered Architecture)

Using layered architecture consist of 3 layers
we use DI here as part of ASP.NET MVC .NET 8 Framework

1. Presentation Layer (API Layer client can call this layer)
2. business layer
3. data access layer

## 2) 


## 3)

## 4) Doctor Appointment Management Module (Hexagonal Architecture)

## Shared 

Shared project any module can access

--
Folder structure 
...
📦ModularMonolithDoctor
 ┣ 📂ModularMonolithDoctor Start up
 ┃ ┣ 📂DoctorAvailability Module (Layered Architecture)
 ┃ ┣ 📂Module 3
 ┃ ┣ 📂Module 4
 ┃ ┣ 📂Doctor Appointment Management Module (Hexagonal Architecture)
 ┃ ┃ ┃ ┗ 📂Core
 ┃ ┃ ┃ ┗ 📂Shell
...



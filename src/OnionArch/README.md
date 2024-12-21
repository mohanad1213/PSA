# Onion Arch

![Alt text](./Overview.png);

## 1) OnionAPI.Domain

### Purpose:

- Represents the core of the application where business logic and domain entities are defined.

### Responsibilities

- Defines business rules, entities, and value objects.
- Isolated from external concerns like data access, APIs, or UI.
- Does not depend on any other layers.\*

## 2) OnionAPI.Application.Abstractions

### Purpose:

- Provides the contracts for the services and use cases

### Responsibilities

- Defines service contracts and interfaces for application use cases.
- Promotes loose coupling by allowing multiple implementations in different contexts.
- Serves as a bridge between the Domain layer and the implementation in Application.

# Booking System Microservices

## Overview
This repository contains a microservices-based booking system with two primary services: Hotels and Booking. The system is built using .NET Core, Docker, Kubernetes, RabbitMQ, and Mediatr. It follows Domain-Driven Design (DDD), Command Query Responsibility Segregation (CQRS), and Event Sourcing patterns.

## Architecture
The architecture of this booking system is designed to be scalable, maintainable, and resilient. Here's a brief overview of the components:

### Services

#### Hotels Service
- Manages hotel information such as availability, pricing, and details.
- Exposes APIs for CRUD operations on hotel data.

#### Booking Service
- Manages bookings and reservations.
- Handles the entire booking lifecycle from creation to cancellation.

## Technologies
- **.NET Core**: The primary framework for building the microservices.
- **Docker**: Used for containerizing the microservices for easy deployment and scaling.
- **Kubernetes**: Manages container orchestration, ensuring that the microservices are running as expected in a cluster environment.
- **RabbitMQ**: Acts as the message broker to facilitate communication between microservices.
- **Mediatr**: Implements the mediator pattern for handling requests and notifications within the services.
- **DDD (Domain-Driven Design)**: Provides a structured approach to designing the system by modeling the business domain.
- **CQRS (Command Query Responsibility Segregation)**: Segregates read and write operations to optimize performance and scalability.
- **Event Sourcing**: Ensures that all changes to the application state are stored as a sequence of events, providing a reliable audit log and supporting complex business workflows.

## Getting Started
To get started with the Booking System Microservices, follow these steps:

### Prerequisites
Make sure you have the following installed on your machine:
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [Kubernetes](https://kubernetes.io/docs/setup/)
- [RabbitMQ](https://www.rabbitmq.com/download.html)

### Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/your-username/booking-system-microservices.git
    ```
2. Navigate to the project directory:
    ```bash
    cd booking-system-microservices
    ```

3. Build and run the Docker containers:
    ```bash
    docker-compose up --build
    ```

4. Deploy to Kubernetes:
    ```bash
    kubectl apply -f hotelsdepl.yaml
    kubectl apply -f hotels-srv.yaml
    kubectl apply -f bookingdepl.yaml
    kubectl apply -f booking-srv.yaml
    ```



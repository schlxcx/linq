# LINQ – Person Management

**A C# console application for learning and practicing Language Integrated Query (LINQ).**

![Language](./readme-img/language.svg)
![Framework](./readme-img/framework.svg)
![Type](./readme-img/console.svg)

## Overview

This project is a practical C# exercise focused on learning and applying LINQ to collections of objects.

The application simulates a simple school administration system that manages students and teachers in a shared collection.

Using LINQ, the application demonstrates how to filter, sort, group, and analyze data without manually iterating through collections for every query.

The project was developed as part of a programming exercise and is included in my personal software development portfolio.

## Features

The application demonstrates the following LINQ concepts:

- **Filtering** – Select people based on gender, age-related properties, semester, subject, or salary.
- **Sorting** – Order people alphabetically or teachers by salary.
- **Projection** – Select individual properties or generate formatted names.
- **Grouping** – Group students by field of study.
- **Aggregation** – Calculate totals, averages, and counts.
- **Conditional Queries** – Check whether any or all elements meet specific conditions.
- **Distinct Values** – Retrieve unique fields of study.
- **Top Results** – Select the highest-paid teachers.

## Application Structure

The application uses object-oriented programming principles and inheritance.

### Person

The base class contains shared properties:

- First name
- Last name
- Gender
- Birth year
- Calculated age

### Student

Inherits from `Person` and adds:

- Current semester
- Field of study

### Teacher

Inherits from `Person` and adds:

- Teaching subject
- Monthly salary

All students and teachers are stored together in a `List<Person>`.

## LINQ Exercises

The project includes exercises covering:

| Category    | Examples                                                                                   |
| ----------- | ------------------------------------------------------------------------------------------ |
| Filtering   | Find female persons, students in a specific semester, or teachers above a salary threshold |
| Sorting     | Sort by last name and first name, or by salary                                             |
| Projection  | Extract last names or format full names                                                    |
| Aggregation | Count students and teachers, calculate averages and salary totals                          |
| Grouping    | Count students per field of study                                                          |
| Conditions  | Check whether any or all teachers meet salary requirements                                 |
| Distinct    | Retrieve unique fields of study                                                            |
| Selection   | Find the youngest person or the three highest-paid teachers                                |

The exercises focus on LINQ methods such as `Where()`, `OfType()`, `Select()`, `OrderBy()`, `ThenBy()`, `GroupBy()`, `Count()`, `Average()`, `Sum()`, `Any()`, `All()`, `Distinct()`, and `Take()`.

## Technology Stack

| Category             | Technology                                            |
| -------------------- | ----------------------------------------------------- |
| Language             | C#                                                    |
| Framework            | .NET                                                  |
| Application Type     | Console Application                                   |
| Query Technology     | LINQ                                                  |
| Programming Concepts | Object-Oriented Programming, Inheritance, Collections |

## Getting Started

### Prerequisites

- A compatible .NET SDK
- Visual Studio, Visual Studio Code, or another C# development environment

### Running the Application

1. Clone or download the repository.
2. Open the project in a compatible C# development environment.
3. Restore the project dependencies if necessary.
4. Build and run the console application.

The LINQ query results are displayed in the console.

## Project Purpose

This project was created to strengthen my understanding of:

- LINQ query methods and expressions.
- Working with collections in C#.
- Object-oriented programming and inheritance.
- Data filtering, sorting, and grouping.
- Basic statistical operations on collections.
- Writing readable and maintainable C# code.

It is a learning exercise rather than a production application.

## License

No license has been specified for this project.

Unless a license is added, all rights are reserved by default.

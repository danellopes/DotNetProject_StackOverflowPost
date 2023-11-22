### StackOverflow Post

Developed this code as part of the exercises proposed in the course [C# Intermediate: Classes, Interfaces and OOP](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/).

This particular exercise demonstrates how a class should encapsulate data AND behaviour around that data. We do this by exposing only properties and method that don't affect the validity of the class, such as `Title` and `Description`. Other properties like Votes and CreatedDate are only available through the methods `Upvote()`, `Downvote()`, `GetVotes()` and `GetCreatedDate()`.

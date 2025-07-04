# Internship Assignment: E-Commerce System

## Overview
E-Commerce Mini Checkout System . It’s designed to demonstrate solid OOP design in a clear and practical way.

## 📌 Design Thoughts
Abstract Product:The Product class is abstract because you never buy a generic product — only real ones like ShippableProduct or ExpirableShippableProduct.

Interfaces:I used interfaces for shipping and expiry instead of extra base classes. This keeps the design flexible — a product can easily have shipping, expiry, or both.

Virtual Methods:Common checks like IsAvailable and IsExpired can be overridden later. This makes it easy to change rules without rewriting the whole class.

Simple Structure:Each class has one clear job. The code uses clean constructors and easy-to-follow checks.



## Highlights
Encapsulation:
Each class controls its own data and behavior.

Inheritance & Interfaces:
Clear mix of an abstract base class and interfaces for flexible features.

Polymorphism:
Virtual methods make it easy to extend or customize.

Composition:
The cart holds cart items; shipping works on any product that supports shipping.

Single Responsibility:
Every class does one thing only.


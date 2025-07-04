# Internship Assignment: E-Commerce System

## Overview
E-Commerce Mini Checkout System . It’s designed to demonstrate solid OOP design in a clear and practical way.

## Design Thoughts
Abstract product: Product is made abstract because it’s just a blueprint — you never buy a generic product, only concrete ones like ShippableProduct or ExpirableShippableProduct.

Interfaces: Instead of class, I used interfaces for expiry and shipping. This keeps capabilities flexible — a product can easily combine features without complicated base classes.

Virtual methods: Common behaviors like IsAvailable and IsExpired can be customized later by overriding. This makes it easy to add new product rules without rewriting everything.

The design sticks to clear constructor usage, simple checks, and readable flow.

## Highlights
This project shows an understanding of:

Encapsulation: Each class owns its own data and behavior.

Inheritance & Interfaces: Clear mix of abstract base class and interfaces for flexible behaviors.

Polymorphism: Virtual methods make it easy to extend or override.

Composition: The cart has cart items; shipping works on any shippable product list.

Single Responsibility: Each class has a clear, focused job.


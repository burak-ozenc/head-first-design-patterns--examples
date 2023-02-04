# Chapter 4 - PizzaStore

## Factory Method Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The Factory Method Pattern</b> defines an interface for creating an object, but lets subclasses decide which class to instantiate.
Factory Method lets a class defer instantiation to subclass.
</pre>

### Problem
PizzaStore makes pizza with different styles like New York or Chicago style. Each style has different preparation techniques.
In order to provide loose coupling, we need to be able to create Pizza objects with one interface.
Also we should be able to apply different techniques after preparation (eg: New york style is circle, Chicago style is square).  

### Design Principles
Depend upon abstractions. Do not depend upon concrete classes.

### Solution
In Factory Method Pattern, we need abstract creator and product with their concrete implementations.
All our application depends upon abstract Pizza class.
Object creation handled by inheritance.
Our abstract creator is PizzaStore and concrete creators branches(NYPizzaStore, ChicagoPizzaStore).
Our product is Pizza and concrete products are pizza types(NYStyleCheesePizza, etc.).

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
Also we should be able to apply different techniques after preparation (eg: New york style is circle, Chicago style is square)  

### Design Principles
Depend upon abstractions. Do not depend upon concrete classes.

### Solution
# Chapter 3 - StarBuzz

## Decorator Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The Decorator Pattern</b> attaches additional responsibilities to an object dynamically.
Decorators provide a flexible alternative to subclassing for extending functionality. 
</pre>


### Problem
StarBuzz is a coffee shop, which sells different types of coffees. 

Each individual product has its own cost calculating depending on coffee bean, coffee amount, milk type, etc.

A less-complex design is needed for constructing this system. 

### Design Principles
- Classes should be open for extension, but closed for modification.

### Solution

Create abstract Beverage class, all coffee types should inherit from this abstract class to provide flexibility.

Create an abstract CondimentDecorator class( : Beverage) and all condiments should inherit from this class.

At run time, wrap the desired coffee object with the decorator(s), and override the description and cost the coffee object.
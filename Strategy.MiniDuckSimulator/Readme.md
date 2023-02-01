# Chapter 1 - MiniDuckSimulator

## Strategy Pattern


<pre>
<font size="3"><b>Definition</b></font>:
<b>The Strategy Pattern</b> defines a familiy of algorithms, encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from clients that use it.
</pre>

### Problem

We have different kind of objects(duck types - MallardDuck, RubberDuck, ModelDuck etc.) which have same parent class(Duck).

They have properties like flying, quacking or swimming but some of these properties depends on their type.

We need to have a maintainable, flexible and reusable pattern for initializing these objects on runtime.

### Design Principles

-Identity the aspects of your application that vary and separate them from what stays same. 

-Program to interface, not implementation.

-Favor composition over inheritance.

### Solution

Create supertypes for duck objects which sets the behaviours within the object.
Behaviour type set by an interface. 
Also supertypes can be initialize on runtime dynamically.

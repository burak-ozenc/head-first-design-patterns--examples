# Chapter 3 - StarBuzz

## Decorator Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The Observer Pattern</b> defines a one-to-many dependency between objects
so that when one object's state changed, all of its dependents are notified and updated automatically. 
</pre>


### Problem
StarBuzz is a coffee shop, which sells different types of coffees. 
Each individual product has its own cost calculating depending on coffee bean, coffee amount, milk type, etc.
A less-complex design is needed for constructing this system. 

### Design Principles
- Classes should be open for extension, but closed for modification.

### Solution
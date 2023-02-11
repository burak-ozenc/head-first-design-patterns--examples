# Chapter 7 - HomeTheatre

## Facade Pattern

<pre>
<font size="3"><b>Definition</b></font>:
Provides a unified interface to a set of interfaces in a subsystem.
Facade defines a higher-level interface that makes the subsystem easier to use.
</pre>

### Problem
There is a home theatre setup which takes a lot of steps(different interfaces) to set the movie environment. 
This process need to be automated, and need to be gathered in one method which will rule them all. 

### Design Principles
Principle of Least Knowledge, talk only to your immediate friends.

### Solution
The Facade Pattern helps us to simplify and unify the existing interfaces and decouples a client from complex subsystem.
We can implement multiple facades for one subsystem.
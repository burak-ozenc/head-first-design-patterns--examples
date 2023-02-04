# Chapter 4 - KeyfiCiger(custom project)

## Abstract Factory Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The Abstact Factory Pattern</b> provides an interface for creating families or dependent objects without specifying their concrete classes.
</pre>

### Problem
Improving our kebap store, we have new branches in different cities. 
All branches use different ingredients because of geological locations and ingredient supply problems.
To provide consistency and loose coupling on our system, we will use Abstract Factory Pattern.

### Design Principles
Depend upon abstractions. Do not depend on concrete classes.

### Solution
Our Creator and Product abstract classes will remain same(compared to the FactoryMethod.PizzaStore)
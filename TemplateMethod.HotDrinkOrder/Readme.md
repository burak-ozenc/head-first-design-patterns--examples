# Chapter 8 - HotDrinkOrder

## Template Method Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The Template Method Pattern</b>
</pre>

### Problem
There are Tea and Coffee objects which they have similar preparing techniques but differ at some specific points.
Need to be able to override some specific methods on CaffeineBeverage class, so Template Method Pattern will be implemented 


### Design Principles
HollywoodPrinciple - do not call us we will call you.
HollywoodPrinciple similar to DependencyInversion principle but DependencyInversion covers more in depth
while HollywoodPrinciple is a specific technique.
DependencyInversion advises working on abstractions instead of concrete implementations.  
HollywoodPrinciple is a technique which creates hooks to lower-level classes without creating dependencies.
Both provides loose-coupling.

### Solution
Template method here is the CaffeineBeverage abstract class which specifies which class to override and not.
Also includes hook(CustomerWantsCondiments() method) which can be overridden depending on the need of child class.
So, subclasses decide how to implement steps in base template method.
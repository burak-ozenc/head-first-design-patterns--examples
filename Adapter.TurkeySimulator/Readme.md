# Chapter 7 - Turkey Simulator

## Adapter Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The Adapter Pattern</b>
</pre>


### Problem
We want to add Turkey classes to our MiniDuckSimulator. Without changing the Duck interface, we are able to do it in two different ways
which are Object Adapter and Class Adapter.

### Solution
Class Adapter uses subclassing. It inherits from existing interface and reimplements the necessary methods. More simple than Object Adapter.

Object Adapter uses composition which leads us to create existing object in Adapter class and sets methods from the existing class inside of the new Adapter class. 
Can be used when subclassing is not possible or in need of composing multiple classes. Gives more flexibility but cause to more code.

 

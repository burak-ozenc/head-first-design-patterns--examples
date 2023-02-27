# Chapter 10 - Gumball Machine

## State Pattern

<pre>
<font size="3"><b>Definition</b></font>:
<b>The State Pattern</b> allows an object to alter its behaviour when its internal state changes. 
The object will appear to change its class.
</pre>


### Problem

There is a GumballMachine which basically works as a venting machine. You insert a coin, if there is gumball, it gives you one. 
And you have the chance to get a free gumball once in a three.
This context(GumballMachine) has some states like 'NoQuarterState', 'HasQuarterState', 'SoldState', etc. 
To handle these states, we can set them manually with if/else or switch/case statements but it will be open for bugs and will violate OOP principles. 
So we will apply State Pattern which will handle the state transition inside of the context.


# Solution

We create an abstract class for states to inherit, the necessary methods will be overridden by children classes. 
Our context(GumballMachine) class will handle state transition, whatever the necessary state is needed at that time.

Strategy Pattern and State Pattern are really similar to each other. 
The main difference between them is, behaviours set inside of the context, not in runtime, 
so the client know nothing about the states, so it is loosely coupled.
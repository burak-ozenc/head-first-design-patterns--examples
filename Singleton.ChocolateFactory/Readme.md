# Chapter 5 - Singleton Pattern

<pre>
<font size="3"><b>Definition</b></font>
<b>The Singleton Pattern</b> ensures a class has only one instance, and provides a global point of access to it.
</pre>

### Problem

There is a chocolate factory and boiler machines which need to be handled. 
Whole system needs to check if the situation of boiler machine processing correctly.
It should start when the boiler is empty, and finish until it all boiled.
We should have an instance to check the situation of ChocolateBoiler class. 


### Solution

With applying Singleton Pattern, we become sure from the instance can only be created inside of ChocolateBoiler class because it is private.
And also we check if there is an instance already running, so would not be instantiated second time.

But there are some downsides of this solution. 
On async processes, multithreading can instantiate multiple times which can cause our ChocolateBoiler to work anomaly.
To avoid from this anomaly, we have three options.
1- To make synchronized the GetInstance() method, which will cause system will slow, because synchronize calls makes system slower. 
2- To use eager instantiation, which will eagerly create the object from beginning will avoid from this anomaly.
3- Using Double-Check-Lock, which will check our instance double and only synchronize on initiation. This will give us the best performance.
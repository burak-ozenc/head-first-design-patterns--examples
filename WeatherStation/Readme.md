# Chapter 2 - WeatherStation

## Observer Pattern


<pre>
<font size="3"><b>Definition</b></font>:
<b>The Observer Pattern</b> defines a one-to-many dependency between objects
so that when one object's state changed, all of its dependents are notified and updated automatically. 
</pre>

### Problem

We will receive an update on WeatherData and display with various ways. 
This process should happen automatically, if the system receives any update on weather data, all display items should be be updated immediately.

We will use Observer Pattern, which gives us the power to update all subscribers when a new data received on publisher class.

Also the display data should be available for third party consumers.

### Design Principles

-Strive for loosely coupled designs between objects that interact.

### Solution

We have publisher, WeatherData, and subscriber which is CurrentConditionDisplay.

WeatherData class inherits from ISubject, CurrentConditionDisplay class  inherits from IDisplay and IObject classes.

When WeatherData class get updated, it automatically updates the registered Display classes(observers).

Any subscriber can be added or removed on runtime.

Also WeatherData class is loosely coupled, unaware of the observer objects, so that it can handle any kind of display and subscriber.
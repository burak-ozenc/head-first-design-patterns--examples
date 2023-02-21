# Chapter 9 - Part2 - Multiple Menu and Submenu Merge

## Composite Pattern
<pre><font size="3"><b>Definition</b></font>
<b>The Composite Pattern</b> allows you to compose objects into tree structures to represent part-whole hierarchies.
Composite lets clients treat individual objects and composition of objects uniformly.
</pre>

### Problem
There will multiple menus and submenus for a restaurant.
Need to compose these menus uniformly.

### Solution
We created a tree-structure for Menu-MenuItems relationships.
Menus are component objects and can have multiple MenuItems-Menus, MenuItems are leaf objects and they cannot have any sub-object.  
Menu and MenuItem inherits from MenuComponent abstract class. Although they do not have exact same methods and for some methods are child-specific, it allows to act same for every object in needed cases.

Therefore there are many design tradeoffs in implementing Composite Pattern. We violate Single Responsibility and had to tradeoff transparency with this design principle and safety issues.
Transparency here means we allow client to use every method on component or leaf objects and client can check the child-object is Menu or MenuItem. 
And for safety, some implementation of MenuComponent abstract classes have to return error for child-specific methods and client can try to call them.


This project also contains Iterator Pattern. We traverse along within our tree structure for Vegetarian MenuItem object search. We used built-in C# IEnumerator<object> class for this reason.
And also for the right error handling, we skip the Menu objects with NullIterator.
# Chapter 9 - Part1 - ObjectVilleDinerHouse-PancakeHouseMerge 

## Iterator Pattern

<pre><font size="3"><b>Definition</b></font>:
<b>The Iterator Pattern</b> provides a way to access the elements of an aggregate object sequantially
without exposing its underlying representation.
</pre>

### Problem
Two restaurant menu's will be merged. Both handles their existing behaviour in different ways.
A general method should be written to merge these menus, without changing the existing codes.
Iterator Pattern will be used.

###
We have two concrete menus which are similar but using different return objects(DinerMenu(item[]) and Pancake House Menu(ArrayList)).
Client need to be able to call the these methods without duplicating code.
We create an Iterator interface, and two concrete implementation for handling different result, 
so we get rid of code duplication on Client code.
# Lab06-OOP-Zoo
![.NET Core](https://github.com/mrsantons/Lab06-OOP-Zoo/workflows/.NET%20Core/badge.svg?branch=master)


## Problem Domain
A zoo contains animals, and animals can come in many different shapes and sizes. It is your job to plan and build out what animals live in the zoo.

## Set Up


Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```Lab06-OOP-Zoo``` directory.

Then select and open ```MarieZoo.sln```


## Visuals

**Start**




## Planning 
![Zoo Diagram](https://github.com/mrsantons/Lab06-OOP-Zoo/blob/master/Assets/ZooDiagram.jpg)


## Four OOP Principles Used
 ------------------------------------------------------------------------------------------------------------------------------------

### Inheritance

Inheritance is the process by which one class takes on the attributes and methods of another. 
Newly formed classes are called child classes, and the classes that child classes are derived from 
are called parent classes.

It's important to note that child classes override or extend the functionality (e.g., attributes and behaviors) of parent classes. In other words, child classes inherit all of the parent's attributes and behaviors but can also specify different behavior to follow. The most basic type of class is an object, 
which generally all other classes inherit as their parent.

#### Single Inheritance
When you do single inheritance, you are only passing on one class's behavior onto a derived class. This is 
the most common type of inheritance amongst programming languages. (C# only support single inheritance)


### Abstraction

in OOP - Abstract classes are not supposed to be instantiated. They are only supposed to be used as a template that can be
derived further down for more clarity. 

Abstract classes cannot be instantiated. 

Abstract methods must be overridden. 

### Polymorphism
Breaking down the work "Polymorphism":

*Poly means many*

*Morph means to change*

Within polymorphism, we want the ability to change the behavior of a specific class. We also want to be able to target specific types of classes (classes that are derived from specific classes). Polymorphism also helps us target any and all classes that implement specific interfaces. 

The ability to override an abstract or virtual method is polymorphism. 


### Encapsulation

Encapsulation is the process of hiding implementation details from the user.
Encapsulation is the act of hiding methods and attributes that should not be exposed to unauthorized or unneeded
classes or methods. Examples of encapsulation are Public, private, and protected. 

Access Modifiers: 
1. Public - Everyone has access
1. Private - Only the class has access to it
1. Protected - the class and any of it's derived children have access. 


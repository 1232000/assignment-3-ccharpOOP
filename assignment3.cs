
//----------------------------------------------------------------------------
// Q1 : Identify the type of relationship in each scenario below (Inheritance, Association, Aggregation, Composition, or Dependency):

// a) A University has Departments. If the university is closed, the departments no longer exist.
// composition

// b) A Driver uses a Car. The driver does not own the car.
// association

// c) A Dog is an Animal.
// inheritance

// d) A Team has Players. If the team is deleted, the players still exist.
// aggregation

// e) A method receives a Logger as a parameter and calls it inside the method only.
// dependency
//----------------------------------------------------------------------------
// Q2 : Answer the following questions about access modifiers and sealed:

// a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
// yes, a child class in a different assembly can inherit from protected parent
// an object from outside can't reach the protected parent class

// b) What is the difference between protected internal and private protected?
// protected internal => in the same assembly or child in different assembly
// private protected => in the same class or child only in same assembly

// c) What does the sealed keyword do when applied to a class? What about when applied to a method?
// sealed class can't be inherited, it stops the inheritance chain completely
// we put sealed method on virtual method, it allows overriding only for the direct child  

// d) Can you create an object from a sealed class using new? Why or why not?
// yes, sealed class means that class can't be inherited, but we can create an object
//----------------------------------------------------------------------------
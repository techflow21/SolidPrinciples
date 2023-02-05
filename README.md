
# Implementation of SOLID Principles

# 1. For Single Responsibility Principle (SRP) 
The Customer class is responsible for handling customer information, and the Order class is responsible for handling customer orders. Each class has a single responsibility and does not handle tasks that are not related to its specific purpose. This follows the Single Responsibility Principle and makes the code easier to maintain and understand.

# 2. For Open/Close Principle (OCP)
In the first example, the Student class is open for extension (able to be inherited from) but closed for modification(the base class is not modified when new functionality is added). The SeniorStudent class inherits from the Student class and adds a new property and overrides the PrintStudent method to include the new property.

In the second example, the Order class is open for extension(new payment methods can be added without modifying the Order class) but closed for modification(the Order class does not need to be modified to handle new payment methods). The IPayment interface and the CreditCardPayment and PayPalPayment classes are used to demonstrate how new payment methods can be added to the system without modifying the Order class.

# 3. For Liskov Substitution Principle(LSP)
//In the first example, the abstract Student class defines the CalculateGPA method that must be implemented by all subclasses.The UndergradStudent and GradStudent classes inherit from the Student class and implement the CalculateGPA method.This demonstrates the Liskov Substitution Principle because any instance of a subclass can be used wherever an instance of the base class is expected, and the program will still function correctly.

In the second example, the IProduct interface defines the Name, Price, and CalculateTax properties and methods that must be implemented by all subclasses.The Book and Electronic classes inherit from the IProduct interface and implement the properties and methods.The ShoppingCart class accepts an array of IProduct instances and calculates the total by summing the Price and CalculateTax of each product.This demonstrates the Liskov Substitution Principle because any instance of a subclass can be used wherever an instance of the IProduct interface is expected, and the program will still function correctly.


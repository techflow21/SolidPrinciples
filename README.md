
# Implementation of SOLID Principles

# 1. For Single Responsibility Principle (SRP) 
The Customer class is responsible for handling customer information, and the Order class is responsible for handling customer orders. Each class has a single responsibility and does not handle tasks that are not related to its specific purpose. This follows the Single Responsibility Principle and makes the code easier to maintain and understand.

# 2. For Open/Close Principle (OCP)
In the first example, the Student class is open for extension (able to be inherited from) but closed for modification(the base class is not modified when new functionality is added). The SeniorStudent class inherits from the Student class and adds a new property and overrides the PrintStudent method to include the new property.

In the second example, the Order class is open for extension(new payment methods can be added without modifying the Order class) but closed for modification(the Order class does not need to be modified to handle new payment methods). The IPayment interface and the CreditCardPayment and PayPalPayment classes are used to demonstrate how new payment methods can be added to the system without modifying the Order class.


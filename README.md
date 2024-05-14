# Factory Design Patterns in C#

Factory Design Patterns are part of the Creational Design Patterns, which focus on the object creation process in software development. These patterns provide a way to encapsulate the instantiation logic of objects, allowing a system to remain independent of how its objects are created and represented.

## Simple Factory Design Pattern

### Definition
The Simple Factory Design Pattern is not a formal pattern but rather a programming idiom. It is a class that can create objects of various types based on the input it receives. It simplifies object creation by encapsulating the logic within a single method.

### Explanation
A Simple Factory has a method that returns different instances of a class based on the parameters passed to it. This method typically uses a series of `if` or `switch` statements to decide which class to instantiate.

### Code Explanation
1. **Product Interface (`ICreditCard`)**:
   - The `ICreditCard` interface defines the common methods that all credit card products must implement.
   - It includes properties like `CardType`, `CreditLimit`, and `AnnualCharge`.

2. **Concrete Products (`MoneyBackCreditCard`, `TitaniumCreditCard`, `PlatinumCreditCard`)**:
   - These classes implement the `ICreditCard` interface.
   - Each concrete product represents a specific type of credit card (e.g., MoneyBack, Titanium, Platinum).
   - They provide actual values for the properties (credit limit, annual charge) based on the card type.

3. **Simple Factory (`CreditCardFactory`)**:
   - The `CreditCardFactory` class contains a static method `GetCreditCard(string cardType)` that creates and returns an instance of a credit card based on the input `cardType`.
   - It uses conditional statements (e.g., `if`, `switch`) to determine which concrete product to instantiate.
   - The client code interacts with this factory to get the desired credit card.

## Factory Method Design Pattern

### Definition
The Factory Method Design Pattern defines an interface for creating an object but lets subclasses decide which class to instantiate. It allows a class to defer instantiation to subclasses, promoting loose coupling and scalability.

### Explanation
In this pattern, an abstract class exposes a method for creating objects, which is then overridden by concrete subclasses to create specific types of objects. This pattern is particularly useful when a class cannot anticipate the class of objects it needs to create.

### Code Explanation
1. **Creator Abstract Class (`CardFactory`)**:
   - The `CardFactory` abstract class declares an abstract method `GetCreditCard()`.
   - Concrete subclasses (e.g., `MoneyBackFactory`, `TitaniumFactory`, `PlatinumFactory`) override this method to create specific credit card products.

2. **Concrete Creators (`MoneyBackFactory`, `TitaniumFactory`, `PlatinumFactory`)**:
   - These classes extend the `CardFactory` and provide implementations for creating specific credit card products.
   - Each concrete creator is responsible for instantiating a particular type of credit card.

3. **Client Code**:
   - In the `Main` method, we create instances of concrete factories (e.g., `MoneyBackFactory`).
   - The client interacts with the factory to get the desired credit card.
   - The factory’s `CreateCreditCard()` method returns an instance of the appropriate credit card product.

## Abstract Factory Design Pattern

### Definition
The Abstract Factory Design Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. It involves multiple factories to create related objects.

### Explanation
Abstract Factory uses multiple factory methods to create a suite of related objects. The client interacts with an abstract interface to create a family of objects. Each family is encapsulated by a concrete factory that implements the abstract factory interface.

### Code Explanation
1. **Abstract Product A (`ICreditCard`)**:
   - The `ICreditCard` interface defines the common behavior for different types of credit cards.
   - Concrete credit card classes (e.g., `MoneyBackCreditCard`, `TitaniumCreditCard`) implement this interface.

2. **Concrete Products (`MoneyBackCreditCard`, `TitaniumCreditCard`)**:
   - These classes provide specific implementations for the credit card products.
   - Each concrete product corresponds to a particular type of credit card.

3. **Abstract Factory (`ICreditCardFactory`)**:
   - The `ICreditCardFactory` interface declares methods for creating credit cards.
   - Concrete factories (e.g., `MoneyBackFactory`, `TitaniumFactory`) implement this interface.

4. **Concrete Factories (`MoneyBackFactory`, `TitaniumFactory`)**:
   - These classes implement the `ICreditCardFactory` interface.
   - Each factory is responsible for creating a family of related credit card products (e.g., MoneyBack cards, Titanium cards).

5. **Client Code**:
   - In the `Main` method, we create an instance of a concrete factory (e.g., `MoneyBackFactory`).
   - The client interacts with the factory to create a specific credit card.
   - The factory’s `CreateCreditCard()` method returns an instance of the appropriate credit card product.

## Usage

- **Simple Factory**: Use when you have a small number of classes, and the client knows what class to instantiate.
- **Factory Method**: Use when there is a need to delegate the instantiation process to subclasses.
- **Abstract Factory**: Use when the system needs to be independent of how its products are created, composed, and represented.

## Conclusion

Factory Design Patterns are crucial for writing decoupled code. They provide flexibility and extensibility to the object creation process, making the system easier to maintain and extend.

For more detailed examples and explanations, please refer to the following resources:
- Factory Design Pattern in C# with Examples
- Factory Method Design Pattern in C#
- Object Creation in C# with the Factory Pattern
- Factory Method Design Pattern - DotNetTricks
- C# Design Patterns - Factory Method - Code Maze

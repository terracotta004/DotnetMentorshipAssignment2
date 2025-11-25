# MentorCruise-DotnetObjectOrientedProgramming

### **Part 1: Classes and Objects**

1. **Create a `Person` class** with the following properties:
    - `Name` (string)
    - `Age` (int)
    
    Add the following methods to the class:
    
    - `SayHello()` that prints a greeting message using the person's name (e.g., "Hello, my name is [Name].")
    - `CelebrateBirthday()` that increases the `Age` by 1 and prints a message (e.g., "Happy Birthday! You're now [Age] years old.")
2. **Create at least two `Person` objects** in your `Main` method:
    - Initialize the `Person` objects with sample names and ages.
    - Call their `SayHello()` and `CelebrateBirthday()` methods.

### **Part 2: Constructors**

- Modify the `Person` class to include a constructor that initializes the `Name` and `Age` properties when an object is created.
    - Your constructor should take `Name` and `Age` as parameters.
    - If no parameters are passed, the `Person` should be initialized with default values ("Unknown" for Name and 0 for Age).
- **Test the constructor** by creating two `Person` objects:
    - One using the constructor with parameters.
    - One using the default constructor.

### **Part 3: Access Modifiers**

- Modify the `Person` class to implement **encapsulation**:
    - Make the `Name` and `Age` properties private and provide **public** getter and setter methods for both.
    - Ensure the `SayHello()` and `CelebrateBirthday()` methods are **public**.
- **Test encapsulation**:
    - Ensure you cannot directly modify the `Name` and `Age` properties from outside the `Person` class. You should use the setter method to modify these properties.

### **Part 4: Inheritance**

- **Create a subclass `Student`** that inherits from `Person`:
    - Add a new property `Grade` (string) to represent the student's grade level (e.g., "A", "B", etc.).
    - Add a method `Study()` that prints a message (e.g., "Studying hard for the next exam!").
- **Override the `SayHello()` method** in the `Student` class:
    - The overridden method should include both the student's name and grade (e.g., "Hello, my name is [Name] and I am in grade [Grade].")
- **Test inheritance**:
    - Create a `Student` object, initialize it with `Name`, `Age`, and `Grade`, and test both the inherited and overridden methods (`SayHello()` and `Study()`).

### **Part 5: Polymorphism**

- **Implement Polymorphism** by creating an interface `IPlayable` with a method `Play()`.
- Create two classes, `FootballPlayer` and `Guitarist`, that both implement `IPlayable`.
- In each class, implement the `Play()` method to print something related to their activity (e.g., "Playing football" and "Playing the guitar").
- **Test Polymorphism**:
- Create objects of both `FootballPlayer` and `Guitarist` and call their `Play()` method. Verify that even though the method is the same (`Play()`), it behaves differently depending on the object type.
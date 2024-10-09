# CodeSmell


https://enterprisecraftsmanship.com/posts/functional-c-handling-failures-input-errors/

Code smell: Primitive Obsession

“Just a field for storing some data!”

How should different types of data be represented? For example, email address, password, phone number, zip code, and home address. Also, how to represent customer names?

If your answer to all or most of them is "String", you suffer from what software development experts call "Primitive Obsession". 

Look at the below lines:

String phoneNumber = "(+98)912 345 6789";
String zipCode = "91889-95999"
zipCode = phoneNumber; //works fine

Technically it's ok and it will compile because a string will always be a string. 
But what about business rules?


Primitive obsession is problematic for several reasons:
1. Weak type checking:
It’s easy to inadvertently pass a customerId as a resourceId to a method. Or, if a method requires both a customerId and resourceId, it’s easy to mistakenly pass the parameters in the wrong order.

2. Limited built-in functionality for specific data types:
We often need to write additional code to perform tasks such as email address validation or phone number formatting. The problem is the repetitive and scattered nature of these implementations. It increases the risk of errors and also makes the code harder to maintain and refactor.

3. Reduced maintainability and loss of domain knowledge:
Scattering business rules and logic across the codebase makes it harder to maintain and evolve the software. Extensive use of primitives can make it challenging to understand the purpose and constraints of the data they represent.

Solution:
Replace Data Value with Object.
Introduce Parameter Object.

Payoff:
Stronger type safety.
Code becomes more flexible.
Better understandability and organization of code.
Easier finding of duplicate code.

Drawback:
Code complexity.
Increase the mental burden when reading the code.
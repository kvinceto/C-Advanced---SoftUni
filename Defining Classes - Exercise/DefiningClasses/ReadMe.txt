1. Define a Class Person
Define a class Person with private fields for name and age and public properties Name and Age.

2. Creating Constructors
Add 3 constructors to the Person class from the last task. Use constructor chaining to reuse code:
•	The first should take no arguments and produce a person with the name "No name" and age = 1. 
•	The second should accept only an integer number for the age and produce a person with the name 
"No name" and age equal to the passed parameter.
•	The third one should accept a string for the name and an integer for the age and should produce 
a person with the given name and age.

3. Oldest Family Member
Use your Person class from the previous tasks. 
Create a class Family. 
The class should have a list of people, a method for adding members - void AddMember(Person member), 
and a method returning the oldest family member – Person GetOldestMember(). 
Write a program that reads the names and ages of N people and adds them to the family. 
Then print the name and age of the oldest member. 
Examples
Input		Output
3
Peter 3
George 4
Annie 5	
		Annie 5

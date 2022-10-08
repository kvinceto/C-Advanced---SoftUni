7.	Tuple
First, we are going to focus on the Tuple's type, which contains two objects. 
The first one is "item1" and the second one is "item2". 
It is kind of like a KeyValuePair, except – it simply has items, which are neither key nor value. 
Your task is to create a class "Tuple", which holds two objects. The first one will be "item1" and the second one – "item2". 
The tricky part here is to make the class hold generics. 
This means, that when you create a new object of class – "Tuple", there should be a way to explicitly specify both items' types separately.

Input

The input consists of three lines:
•	The first one is holding a person's name and an address. They are separated by space(s). 
Your task is to collect them in the tuple and print them on the console. Format of the input:
{first name} {last name} {address}
•	The second line holds a name of a person and the amount of beer (int) he can drink. Format:
{name} {liters of beer}
•	The last line will hold an integer and a double. Format:
{integer} {double}

Output

•	Print the tuples’ items in format: {item1} -> {item2}
Constraints
•	Use the good practices we have learned. Create the class and make it have getters and setters for its class variables. 
The input will be valid, no need to check it explicitly!

Examples
Input				Output
Adam Smith California
Mark 2
23 21.23212321	
				Adam Smith -> California
				Mark -> 2
				23	-> 21.23212321


1.	Car
Create a class named Car. The class should have private fields for:
•	make: string
•	model: string
•	year: int
The class should also have public properties for:
•	Make: string
•	Model: string
•	Year: int

2.	Car Extension
Create a class Car (you can use the class from the previous task)
The class should have private fields for:
•	make: string
•	model: string
•	year: int
•	fuelQuantity: double
•	fuelConsumption: double
The class should also have properties for:
•	Make: string
•	Model: string
•	Year: int
•	FuelQuantity: double
•	FuelConsumption: double
The class should also have methods for:
•	Drive(double distance): void – This method checks if the car fuel quantity minus
the distance multiplied by the car fuel consumption is bigger than zero. 
If it is removed from the fuel quantity the result of the multiplication between the distance and the fuel consumption. 
Otherwise, write on the console the following message:  
"Not enough fuel to perform this trip!"
•	WhoAmI(): string – returns the following message: 
"Make: {this.Make}
 Model: {this.Model}
 Year: {this.Year}
 Fuel: {this.FuelQuantity:F2}"

3.	Car Constructors
Using the class from the previous problem create one parameterless constructor with default values:
•	Make – VW
•	Model – Golf
•	Year – 2025
•	FuelQuantity – 200
•	FuelConsumption – 10
Create a second constructor accepting make, model, and year upon initialization and call the base constructor 
with its default values for fuelQuantity and fuelConsumption.
 
Create a third constructor accepting make, model, year, fuelQuantity, and fuelConsumption upon initialization 
and reuse the second constructor to set the make, model, and year values.

4.	Car Engine and Tires
Using the Car class, you already created, define another class Engine.
The class should have private fields for:
•	horsePower: int
•	cubicCapacity: double
The class should also have properties for:
•	HorsePower: int
•	CubicCapacity: double
The class should also have a constructor, which accepts horsepower and cubicCapacity upon initialization:
 
Now create a class Tire.
The class should have private fields for:
•	year: int
•	pressure: double
The class should also have properties for:
•	Year: int
•	Pressure: double
The class should also have a constructor, which accepts year and pressure upon initialization:
 
Finally, go to the Car class and create private fields and public properties for Engine and Tire[].
Create another constructor, which accepts make, model, year, fuelQuantity, fuelConsumption, Engine, and Tire[] upon initialization:

5.	Special Cars
Until you receive the command "No more tires", you will be given tire info in the format:
{year} {pressure}
{year} {pressure}
…
"No more tires"
You have to collect all the tires provided. 
Next, until you receive the command "Engines done" you will be given engine info and you also have to collect all that info.
{horsePower} {cubicCapacity} 
{horsePower} {cubicCapacity} 
…
The final step - until you receive "Show special", you will be given information about cars in the format:
{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
…
Every time you have to create a new Car with the information provided. 
The car engine is the provided engineIndex and the tires are tiresIndex. 
Finally, collect all the created cars. When you receive the command "Show special", 
drive 20 kilometers all the cars, which were manufactured during 2017 or after, 
have horsepower above 330 and the sum of their tire pressure is between 9 and 10. 
Finally, print information about each special car in the following format:
"Make: {specialCar.Make}"
"Model: {specialCar.Model}"
"Year: {specialCar.Year}"
"HorsePowers: {specialCar.Engine.HorsePower}"
"FuelQuantity: {specialCar.FuelQuantity}"


Input					Output
2 2.6 3 1.6 2 3.6 3 1.6
1 3.3 2 1.6 5 2.4 1 3.2
No more tires
331 2.2
145 2.0
Engines done
Audi A5 2017 200 12 0 0
BMW X5 2007 175 18 1 1
Show special	
					Make: Audi
					Model: A5
					Year: 2017
					HorsePowers: 331
					FuelQuantity: 197.6


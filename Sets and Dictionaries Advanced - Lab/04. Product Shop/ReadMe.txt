
4.	Product Shop
Create a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".  Keep in mind that if you receive a shop you already have received, you must collect its product information.
Your output must be ordered by shop name and must be in the format:
"{shop}->
Product: {product}, Price: {price}"
Note: The price should not be rounded or formatted.
Examples
Input				Output
lidl, juice, 2.30
fantastico, apple, 1.20
kaufland, banana, 1.10
fantastico, grape, 2.20
Revision	
				fantastico->
				Product: apple, Price: 1.2
				Product: grape, Price: 2.2
				kaufland->
				Product: banana, Price: 1.1
				lidl->
				Product: juice, Price: 2.3

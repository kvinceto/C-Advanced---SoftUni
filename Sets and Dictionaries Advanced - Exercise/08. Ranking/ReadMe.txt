Problem 8.	*Ranking
Create a program that ranks candidate-interns, depending on the points from the interview tasks and their exam results in SoftUni. 
You will receive some lines of input in the format "{contest}:{password for contest}" until you receive "end of contests". 
Save that data because you will need it later. 
After that you will receive another type of inputs in the format "{contest}=>{password}=>{username}=>{points}" 
until you receive "end of submissions". Here is what you need to do:
•	Check if the contest is valid (if you received it in the first type of input)
•	Check if the password is correct for the given contest
•	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest. If you receive the same contest and the same user, update the points only if the new ones are more than the older ones.
At the end you have to print the info for the user with the most points in the format:
"Best candidate is {user} with total {total points} points.". 
After that print all students ordered by their names. 
For each user, print each contest with the points in descending order in the following format:
"{user1 name}
#  {contest1} -> {points}
#  {contest2} -> {points}
{user2 name}
…"
Input
•	You will be receiving strings in the formats described above, until the appropriate commands, also described above, are given.
Output
•	On the first line print, the best user in the format described above. 
•	On the next lines print all students ordered as mentioned above in format.
Constraints
•	There will be no case with two equal contests.
•	The strings may contain any ASCII character except (:, =, >).
•	The numbers will be in the range [0 - 10000].
•	The second input is always valid.
•	There will be no case with 2 or more users with the same total points.
Examples
Input					Output
Part One Interview:success
Js Fundamentals:JSFundPass
C# Fundamentals:fundPass
Algorithms:fun
end of contests
C# Fundamentals=>fundPass=>Tanya=>350
Algorithms=>fun=>Tanya=>380
Part One Interview=>success=>Nikola=>120
Java Basics Exam=>JSFundPass=>Parker=>400
Part One Interview=>success=>Tanya=>220
OOP Advanced=>password123=>BaiIvan=>231
C# Fundamentals=>fundPass=>Tanya=>250
C# Fundamentals=>fundPass=>Nikola=>200
Js Fundamentals=>JSFundPass=>Tanya=>400
end of submissions	
					Best candidate is Tanya with total 1350 points.
					Ranking:
					Nikola
					#  C# Fundamentals -> 200
					#  Part One Interview -> 120
					Tanya
					#  Js Fundamentals -> 400
					#  Algorithms -> 380
					#  C# Fundamentals -> 350
					#  Part One Interview -> 220

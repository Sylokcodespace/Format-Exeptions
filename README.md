
OVERVIEW
The program's purpose is to intake miles driven and gallons used and calculates the output from a string to a double with a format exception to catch anything else that does not follow the intake or the gallons used and the calculated output.
PROCESSING LOGIC
The logic is to have user input miles driven and gallons used as a string input then have the output be calculated of both miles driven and gallons used as a double format and anything else will result in a format exception to tell the user they imputed something wrong and to try again.
DATA (INPUT/OUTPUT)
the input from user will be a string of miles driven and gallons used the output will be either a format exception if user did not input data properly and will retry the loop for user to input the data again, the input if user inputs data properly will stop the loop and continue to the calculated amount of miles driven and gallons used.
COMPONENTS (SOURCE CODE NAMES, CLASSES, METHODS)
these are the software components.
|fuel efficiency app|
|- milesdriven: double|
|- gallonsUsed: double| 
|+run(): void |
|+getuserInput (prompt, string): double |
|+ CalculateMPG(miles: double, gallons: double): double |
|+ Displayresult (mpg: double) |
|- handleformat exceptions (): void |
+-	-	-	-	-+
 TESTING
example scenario of passing  300 miles driven divided by 10 gallons used, is 30.0 mpg

example scenario of failing miles drove, abc 10 gallons used that's not a valid input.

AY 2023-24 DM

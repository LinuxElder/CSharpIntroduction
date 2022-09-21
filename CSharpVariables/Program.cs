using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;

Console.WriteLine("Hello, World!");

// SYNTAX[ DataType variableName = value; ]
/* NAMING RULES
 Variables must start with underscore or letter
 Variables cannot contain spaces
 variables can contain numbers
 Cannot contain symbols (accept underscore) */

// EXAMPLE
string myname = "Simbarashe Marimo";
int myage = 25;
int year = 2022;
Console.WriteLine("My name is " + myname + " and I am " + myage + " years old.");
Console.WriteLine("Current year is " + year + "\n");

// Arrays
/* Arrays are similar to variables, but can hold more than one value.
SYNTAX
DataType[ ] ArrayName = { Comma Separated Values } // Array of any size
DataType[] ArrayName = new DataType[3] {Command Separated Values } //Expects 3 values */

// EXAMPLE
string[] BestGames = { "GTA 5", "Fifa 2022" };
string[] BestMovies = new string[3] { "Fantastic Beasts", "22 Jump Street", "How To Train Your Gragon" };
Console.WriteLine(BestGames[0]);
Console.WriteLine(BestMovies[0] + "\n");

//STRINGS
/* CONCATENATION
Concatenation is done through the + operator. */

// EXAMPLE
Console.WriteLine("Hello " + "World");

// New Line
// Example 
Console.WriteLine("Hello \n" + "World \n");

// STRING.FORMAT
/* Formats an object, you specify the formatting you wish to perform, the following formats an integer and displays the currency symbol. In my case the US dollar Sign*/
Console.WriteLine("STRING FORMATING");
Console.WriteLine(string.Format("{0:C}", 5) + "\n");

// IF STATEMENTS
/* if statement is used to execute code based on a condition the condition must evaluate to true for the code to execute.
  SYNTAX
        if (true)
                {
                    statements
                }
 */

// Example
Console.WriteLine("IF Statement");
if (year > 2010)
{
    Console.WriteLine("Year is greater than 2010 \n");
}


// IF ELSE
// //Example

Console.WriteLine("IF ELSE Statement");
if (year > 2023)
{
    Console.WriteLine("Hello World " + year);
}

else
{
    Console.WriteLine("The year is " + year + "\n");
}

// SWITCH STATEMENT
/* Similar to the If else statement, however it has these benefits.
 Much easier to read and maintain
 Much cleaner then using nested if else
 It only evaluates one variable */

/* SYNTAX
switch (switch_on)
{
case 1:
        statements;
      break;

case 2:
        statements;
       break;

default:
} */

//EXAMPLE 

switch (year)
{
    case 2013:
        Console.WriteLine("The year is 2013 ! \n");
        break;

    case 2015:
        Console.WriteLine("The year is 2015 !\n");
        break;

    default:
        Console.WriteLine("It`s " + year + " ! \n");
        break;
        //The break keyword is required as it prevents case falling.
}

/*LOOPS
WHILE LOOP
Continuously loops code until the condition becomes false.
SYNTAX
while (true)
{
}
EXAMPLE
while (Year >= 2013)
{
if (Year != 2100)
{
Console.WriteLine(Year++);
}
else
{
break;
}
}
Make sure your condition evaluates to false at some point otherwise the loop is endless and it can result in errors.
FOR LOOP
Similar to the While Loop, but you specify when the loop will end.
SYNTAX
for (int i = 0; i < length; i++)
{
}
EXAMPLE
for (int i = 0; i <= 100; i++)
{
Console.WriteLine(i);
}
This prints out 1 to 100. The expression can be easily broken down like this:
I = 0;
I Is less than or equal to 100? (True)
Increment I by 1
When I reaches 100 it will stop because I will no longer be less than100 and will equal 100 so the condition is false.
FOR EACH
The for each loop is used to loop around a collection. (Such as an array)
SYNTAX
foreach (var item in collection)
{
}
EXAMPLE
foreach (string movie in MyMoveisOf2013)
{
Console.WriteLine(movie);
}
Outputs all the elements in the MyMoviesOf2013 array.
*/

// ADVANCED – EXCEPTIONS, METHODS & CLASSES
// EXCEPTIONS
// To catch any exceptions which are likely to occur you use a try catch block.

/* SYNTAX
try
{
}
catch (Exception)
{
    throw;
}
*/

// EXAMPLE
try
{
    string result = "k";
    Console.WriteLine(Convert.ToInt32(result) + 10);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//The above code results in a format exception, because you can’t convert K to a number.
/* CLASSES
SYNTAX
Class MyClassName
{
}
*/

// EXAMPLE

MyCar menu=new MyCar();
menu.DisplayMenu();

//Methods Examples
menu.Movie(BestMovies[1]);

menu.MovieYear(BestMovies[1], year);

Console.WriteLine(menu.Tomorrow());



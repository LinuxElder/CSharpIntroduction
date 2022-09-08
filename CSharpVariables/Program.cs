﻿// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

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
    Console.WriteLine("Year is greater than 2010");
}

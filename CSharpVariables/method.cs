using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;

class MyCar
{
    public void DisplayMenu()
    {
        
        //Does not return a value
        Console.WriteLine("Home AboutUs Contact \n");
    }

/*METHODS
SYNTAX
public void MethodName()
    {
        //Does not return a value
    }
    public static void MethodName()
    {
        //Does not return a value, the class does not need to be initialized
        //for this method to be used.
    }
    public static DataType MethodName()
    {
        //Requires a value to be returned, class does not need to be initialized for this method to be used.
    }*/
    //EXAMPLE
public void Movie(string movie)
    {
        Console.WriteLine(movie+"\n");
    }
   // Passing Parameters
public void MovieYear(string movie, int year)
    {
        Console.WriteLine( movie + " was released in "+ year + "\n");
    }
   // Since both methods have the same name and different parameters(One takes no parameters and the other one does) this is said to be an overloaded method.
   
    // Returning Data
public DateTime Tomorrow()
    {
        return DateTime.Now.AddDays(1);
    }
}
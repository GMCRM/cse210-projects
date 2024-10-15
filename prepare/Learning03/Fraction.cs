//instructions: 
// 3. Create a class to hold fraction.
//The class should be in its own file.
//The class should have two attributes for the top and bottom numbers.
//Make sure the attributes are private.

//4. Create the following constructors:
//Constructor that has no parameters that initializes the number to 1/1.
//Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
//Constructor that has two parameters, one for the top and one for the bottom.
//In your Program.cs file, verify that you can create fractions using all three of these constructors. For example, create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor), for 6/7 (using the third constructor).
using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}
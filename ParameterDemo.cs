namespace Week4_Assignment;

public class ParameterDemo
{
    // using REF parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    // using OUT parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Bebish Shrestha";  
    }

    // using PARAMS parameter
    public int SumAll(params int[] numbers)
    {
        return numbers.Sum();
    }
}
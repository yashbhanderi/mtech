namespace mtech;

public class Methods
{
    // // Instance method
    // // Can only call via instace of a class
    // // Methods m = new Methods();
    // // m.SubstactNumbers()
    // public void SubstractNumbers(int x, int y)
    // {
    //     Console.Write($"Substraction of {x} and {y} is : ${x - y}");
    // }

    // // If static method
    // // Then We can call direcly from class name
    // // Methods.AddNumbers()
    // public static void AddNumbers(int x, int y)
    // {
    //     Console.Write($"{x} + {y} is : {x + y}");
    // }

    // public static void Main()
    // {
    //     Methods m = new Methods();
    //     m.SubstractNumbers(5, 6);
    //     Methods.AddNumbers(6, 7);
    // }



    // Pass by Value

    public static void SwapNumbersPassByValue(int x, int y) {
        int temp = x;
        x = y;
        y = temp;
    }

    // Pass by Reference
    public static void SwapNumbersPassByReference(ref int x, ref int y) {
    
        int temp = x;
        x = y;
        y = temp;
    }

    public static void IncrementNumbers(out int x) {
        x = 10;
        x+=1;
    }

    public static void Main() {
        int x = 10, y = 20;

        Console.Write($"Value of x y before function : {x}, {y}\n");
        Methods.SwapNumbersPassByValue(x, y);
        Console.Write($"Value of x y before function : {x}, {y}\n\n");


        // ref keyword

        // ref keyword send the reference of the variable to the function
        // When Some changes are done in the function on the variables
        // It changes on the argument variables...
        // which means parameters are actually the arguments
        // Must be inititalized before sending to the function
        
        Console.Write($"Value of x y before function : {x}, {y}\n");
        Methods.SwapNumbersPassByReference(ref x, ref y);
        Console.Write($"Value of x y before function : {x}, {y}\n\n");


        // out keyword

        // exact same as ref keyword
        // just one change
        // Don't need to initialize before sending to function
        // can initialize any time 

        int z;
        Methods.IncrementNumbers(out z);
        Console.Write(z);    // 11
    }
}
namespace generics;

class Program
{

    private static void SimpleStackStrings()
    {
        // var stack = new SimpleStack();
        // var stack = new SimpleStack<string>();   // Custom Generic Class
        var stack = new Stack<string>();            // Stack Collection
        stack.Push("Hello");
        stack.Push("John");

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
    
    public static void Main()
    {
        // var stack = new SimpleStack();           
        // var stack = new SimpleStack<double>();   // Custom Generic Class
        var stack = new Stack<double>();            // Stack Collection
        stack.Push(6.7);
        stack.Push(2.9);
        stack.Push(1.2);
        stack.Push(10.4);
        SimpleStackStrings();
        
        double sum = 0;
        var count = 0;
        while(stack.Count > 0)
        {
            var item = stack.Pop();
            Console.Write(item+"\n");
            sum += (double)item;
            count++;
        }
        
        Console.WriteLine("Total sum is : " + sum);
        Console.WriteLine("Average is : " + (double)sum/count);
    }
}


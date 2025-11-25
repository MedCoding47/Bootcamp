using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program
{
  
    static void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static void Main(string[] args)
    {
      
        Console.WriteLine("## Exercise 1");
        Console.WriteLine("Hello World!");
        Console.WriteLine("\n");


       
        Console.WriteLine("## Exercise 2");
        string name = "ayat mohamed"; 
        int age = 21;           

        Console.WriteLine($"My name is {name} and I am {age} years old.");
        Console.WriteLine("\n");


        Console.WriteLine("## Exercise 3");
        int num1 = 45;
        int num2 = 12;

        int sum = num1 + num2;

        Console.WriteLine($"The result of {num1} + {num2} is: {sum}");
        Console.WriteLine("\n");


     
        Console.WriteLine("## Exercise 4");
        
        int userAge =15;

        if (userAge >= 18)
        {
            Console.WriteLine("access granted");
        }
        else 
        {
            Console.WriteLine("access denied");
        }
        Console.WriteLine("\n");


    
        Console.WriteLine("#ex 5");
        int counter =10;
        while (counter >=1)

            {
                Console.WriteLine(counter);
                counter--;
            }
    
                Console.WriteLine("finish!");
                Console.WriteLine("\n");


            Console.WriteLine("ex 6");
            SayHello ("ayat");
            SayHello ("mohamed");
            SayHello ("miliodas");
            

          Console.WriteLine("ex 7");
            for (int i=1 ; i<=10 ; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is odd");
            }
        }

           }
}

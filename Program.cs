using System;
using System.Data.Common;

class Program
{
    // -------------- Basic syntax of C# -----------
    // => using system es used to  Tools/libraries and use console,
    // => if we donot use console we have to write "system.Console" every time 
    // => when i have to use console.
    // => class program is our container of structure.
    // => Main()-> its the main function where we will perform our task

    // ==> variables
    static void Main()
    {

        // int age = 25;
        // int for numbers.
        // Console.WriteLine("Age is: " + age);
        // Console.WriteLine() for output.

        // string Name = "Hassan";
        // Console.WriteLine("Your Name is: " + Name);
        //  string for numbers and alphabets called alphanumeric.

        // double weigth = 65.7;
        // Console.WriteLine("Your weight is: " + weigth);
        //  double for decimal values

        // bool isActive = true;
        // Console.WriteLine(isActive);
        //  bool for booleans (true/false)

        // ------------- User Input---------------------
        // Console.ReadLine() ==> used to take input from user

        // Console.WriteLine("Enter your Name: ");
        // string Name = Console.ReadLine();
        // Console.WriteLine("Your Name is: " + Name);
        // Console.WriteLine("Enter Your Age: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("your Age is: " + age);
        // Convert.ToInt32() ===> used to convert string into int, because Console.ReadLine takes input in string.

        // -----------------Basic calculation----------------
        // sum
        // int a = 20;
        // int b = 30;
        // int sum = a + b;
        // Console.WriteLine("Sum is: " + sum);

        // subtract
        // int a = 30;
        // int b = 20;
        // int sub = a - b;
        // Console.WriteLine("Subtract is: " + sub);

        //Product
        // int a = 30;
        // int b = 20;
        // int product = a * b;
        // Console.WriteLine("Product is: " + product);


        //Division
        // int a = 30;
        // int b = 2;
        // int div = a / b;
        // Console.WriteLine("Product is: " + div);

        // ---------if/ else  conditions-----------------------
        // int marks = 78;
        // if (marks >= 70 && marks <= 80)
        // {
        //     Console.WriteLine(" Grade  A");
        // }
        // else if (marks >= 60 && marks <= 70)
        // {
        //     Console.WriteLine(" Grade  b");

        // }
        // else if (marks >= 50 && marks <= 60)
        // {
        //     Console.WriteLine(" Grade  c");

        // }
        // else
        // {
        //     Console.WriteLine("Fail");

        // }

        // ------------For Loop-------------------
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }
        // }
        // ---------------------Assignment--------------------
        // for (int i = 1; i <= 3; i++)
        // {
        //     Console.WriteLine("Student: " + i);
        //     Console.Write("Enter Your Name: ");
        //     string Name = Console.ReadLine();
        //     Console.Write("Enter Your Marks: ");
        //     int marks = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("================ Marksheet ====================== ");
        //     Console.WriteLine("Name: " + Name);
        //     Console.WriteLine("Marks: " + marks);


        //     if (marks >= 70)
        //     {
        //         Console.WriteLine(" Grade  A");
        //     }
        //     else if (marks >= 60 && marks <= 70)
        //     {
        //         Console.WriteLine(" Grade  b");

        //     }
        //     else if (marks >= 50 && marks <= 60)
        //     {
        //         Console.WriteLine(" Grade  c");

        //     }
        //     else
        //     {
        //         Console.WriteLine("Fail");

        //     }

        // }


        // ----------------- Functions-------------------

        // static void Greeting(string name)
        // {
        //     Console.WriteLine("Hello," + name);
        // }
        // Greeting("Hassan");

        // static int Add(int a, int b)
        // {
        //     return a + b;
        // }
        // int sum = Add(5, 15);
        // Console.WriteLine("sum is: " + sum);

        // Console.WriteLine("Enter first number");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // // Console.WriteLine("number 1:" + num1);

        // Console.WriteLine("Enter second number");
        // int num2 = Convert.ToInt32(Console.ReadLine());

        // int result = Calculator(num1, num2);
        // Console.WriteLine("Result: " + result);

        // static int Calculator(int num1, int num2)
        // {
        //     return num1 + num2;
        // }

        //         Code           Meaning
        //         string         null allowed nahi
        //         string?        null allowed
        //         !              force non-null(careful)
        //         ?? ""           fallback value


        // ----------------- Calculator---------------------


        // Console.WriteLine("Enter first number");
        // int num1 = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Enter operator: ");
        // string oprt = Console.ReadLine()!;

        // Console.WriteLine("Enter second number");
        // int num2 = Convert.ToInt32(Console.ReadLine());

        // int result = Calculator(num1, oprt, num2);
        // Console.WriteLine("Your result is: " + result);


        // static int Calculator(int num1, string oprt, int num2)
        // {
        //     if (oprt == "+")
        //     {
        //         return num1 + num2;
        //     }
        //     else if (oprt == "-")
        //     {
        //         return num1 - num2;
        //     }
        //     else if (oprt == "*")
        //     {
        //         return num1 * num2;
        //     }
        //     else if (oprt == "/")
        //     {
        //         return num1 / num2;
        //     }

        //     return 0; // default fallback
        // }








    }
}
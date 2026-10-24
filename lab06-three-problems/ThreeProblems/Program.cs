using System.ComponentModel;

Console.WriteLine("===CSCI 1250 Lab 06===");
Console.WriteLine("1. The grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");

int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1 || choice ==4 )
{
    Console.WriteLine("a");

    }



if (choice == 2 || choice == 4 )
{
    //ex2
      Console.WriteLine("b");
}

if (choice== 3 || choice ==4  )
{
  //ex3    
    Console.WriteLine("c");
}

if (choice== 5 || choice ==4  )
{
  //ex3    
    Console.WriteLine("by by");
}


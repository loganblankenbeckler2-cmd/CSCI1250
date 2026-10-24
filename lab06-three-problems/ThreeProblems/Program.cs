/*
    * name: Logan blankenbeckler 
    *Course: csci 150, section 002
    *Assignment: Lab 06, three short problems
    *Date: 10-21-2026
    *Description: menu that keeps running until the user quits, offering three independent exercises or all three at once. Each exercise practices decisions and one of the four loops. 
    *
    *
 */   


Console.WriteLine("===CSCI 1250 Lab 06===");
Console.WriteLine("1. The grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");

int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1 || choice ==4 )
{
       //ex 1 
Console.WriteLine("===Exercise 1 : The grade Checker ===");
Console.WriteLine("enter score :");
int score = Convert.ToInt32(Console.ReadLine());
    
            // while loop will continure to write message due to logic underneath if " if score is less than zero OR over 100 " if logic is not met program will not loop and procede to if statements for grade. if statements are single pass as of right now.
     while(score < 0 || score > 100)
    {
        Console.WriteLine("A score must be between 0 and 100");
        score = Convert.ToInt32(Console.ReadLine());
    }
        if (score >= 90)
        {
            Console.WriteLine(score +" is an A");

        }
        else if (score < 90 && score >= 80)
        {
            Console.WriteLine(score +" is a B");
        }
         else if (score < 80 && score >= 70)
        {
            Console.WriteLine(score +" is a C");
        }
         else if (score < 70 && score >= 60)
        {
            Console.WriteLine(score +" is a D");
        }
         else if (score < 60 && score >= 0)
        {
            Console.WriteLine(score +" is an F");
        }

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


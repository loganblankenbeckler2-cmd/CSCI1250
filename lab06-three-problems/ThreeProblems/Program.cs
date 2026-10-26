/*
    * name: Logan blankenbeckler 
    *Course: csci 150, section 002
    *Assignment: Lab 06, three short problems
    *Date: 10-21-2026
    *Description: menu that keeps running until the user quits, offering three independent exercises or all three at once. Each exercise practices decisions and one of the four loops. 
    *
    *
 */


using System.Globalization;
using System.Numerics;
int choice;
do// using do while loop so our check happens at the end allowing us to repeat the program until the condition is met ( while statement for do is at the end )
{
Console.WriteLine("\n");
Console.WriteLine("===CSCI 1250 Lab 06===");
Console.WriteLine("1. The grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit" + "\n");
Console.Write("choose 1 through 5 :");


    

Random rng = new Random(4000);
 choice = Convert.ToInt32(Console.ReadLine());
//-----------------------------------------------------------------------------------------------------------------------
while( choice < 1 || choice > 5)//  while : using while loop to check for proper input FIRST before continuing to to the next line of code in this case if user intput is numbers 1 through 5 (repeat if value inputed for choice is less than 1 OR greater than five). this keeps out of range value from proceeding. 



    

        
    

{
Console.Write("enter a number from 1 to 5 : ");
choice = Convert.ToInt32(Console.ReadLine());
}

//----------------------begin menu loop (largest loop)------------

if (choice == 1 || choice ==4 )// IF: using if to create separate statements so EITHER one statement can be ran OR all can be ran when choice equals 4. if " if else " was ued for subsequent statements only one statement could run at a time. 
{
       
    Console.WriteLine("===Exercise 1 : The grade Checker ===");
    Console.Write("enter score :");
    int score = Convert.ToInt32(Console.ReadLine());
    
            
     while(score < 0 || score > 100)//using while loop to check user input FISRT. if input falls out if range ( outside of 0-100) when value falls within range program will procede to next line 
    {
        Console.WriteLine("A score must be between 0 and 100");
        score = Convert.ToInt32(Console.ReadLine());
    }   

    // using if then else if statements because chain will work for this application whith logic in statements. we only need one at a time do display the letter grade a score gives 
        if (score >= 90)
        {
            Console.WriteLine(score +" is an A");

        }
        else if (score < 90 && score >= 80)//
        {
            Console.WriteLine(score +" earns a B");
        }
         else if (score < 80 && score >= 70)
        {
            Console.WriteLine(score +" earns a C");
        }
         else if (score < 70 && score >= 60)
        {
            Console.WriteLine(score +" earns a D");
        }
         else if (score < 60 && score >= 0)
        {
            Console.WriteLine(score +" earns an F");
        }

    }

//----------------------------------------------------------end exercise one/begin excercise 2222222222222222222-----------------------------------------

if (choice == 2 || choice == 4 )// 
{
    Console.WriteLine("===Exercise 2 : The Dice Table===");
    int wincounter = 0;
    int rollCounter = 0;
    string playAgain;
    do // using do while ( while is near bottom of statement) because we need this to run the dice game first then check if we need to proceed to the next line or loop. opposite of while statement where the check happens first then the decision to proceed is made. 
       
        {// do opening
            int diceOne = rng.Next(1, 7);
            int diceTwo = rng.Next(1, 7);
            
            //Console.WriteLine("");
             //Console.WriteLine("");
    
                 if (diceOne ==1 && diceTwo == 1)
                    {
                     rollCounter++;
                     Console.WriteLine("roll " + rollCounter + " : " + diceOne + " and " + diceTwo +", Total: " + (diceOne+diceTwo) +  ", snake eyes");
                    }
                     else if ( diceOne == diceTwo)
                    {
                    rollCounter++;
                     Console.WriteLine("roll " + rollCounter + " : " + diceOne + " and " + diceTwo +", Total: " + (diceOne+diceTwo) +  ", doubles!");
                    }
                     else if ( diceOne + diceTwo == 7 || diceOne + diceTwo == 11)
                    {
                     rollCounter++;
                     wincounter++;
                    Console.WriteLine("roll " + rollCounter + " : " + diceOne + " and " + diceTwo +",Total: " + (diceOne+diceTwo) +  ", a winner!");
                    }
                    else
                    {
                    rollCounter++;
                    Console.WriteLine("roll " + rollCounter + " : " + diceOne + " and " + diceTwo +", Total: " + (diceOne+diceTwo));
                    }



Console.Write("play again? Y or N: ");
    playAgain = Console.ReadLine().ToLower();
      
    while(playAgain != "y" && playAgain !="n")// while statement is used here to check for proper input befor proceeding ( this is not the while belonging to the above do) 
        {
            Console.Write("Y or N please: "); 
          playAgain = (Console.ReadLine().ToLower());
        }

        
    }  //Do closing 
                // (while for above do) do while statement was used to evaluate input After program has ran to decide if program needs to loop. see above do 
        while (playAgain.ToLower()== "y");

Console.WriteLine(" you rolled " + rollCounter + " Times and won " + wincounter );


}// menu if statement closing 

//---------------------------------------End Exercise two/begin exercise 3333333333333333----loop-------------------------------------------------------------------  

if (choice== 3 || choice ==4  )
{
  
  Console.WriteLine("===Exercise 3 : the score report ") ;
    
 
  int [] scoreList = new int [5];
  int sumScore = 0 ;
  
  int passCounter = 0;  
 
  for (int  i = 0; i < 5; i++ )// using for loop to fill each array position with user input. for also allows us to create incremental control using i++ so we can add a value to the array each pass until the logic is met 
    {
        
        Console.Write($" score {i+1} : ");
        scoreList[i] = Convert.ToInt32(Console.ReadLine());
    }

    foreach (int score in scoreList)// using for each for so calculations and logic are applied to/with EACH item in array. values from calculations can then be stored in variable listed above the for loop in this program 
    {
        sumScore += score;  

        if (score >= 60)
        {
            passCounter++;
        } 
    }

  

     double scoreAvg = (double)sumScore / scoreList.Length;
     int highScore = scoreList.Max();
   
    Console.WriteLine("number of scores: " + scoreList.Length);
    Console.WriteLine("total: " + sumScore);
    Console.WriteLine("Average:" + scoreAvg);
    Console.WriteLine("Highest:" + highScore);
    Console.WriteLine("Passing:" + passCounter +  " of " + scoreList.Length);
    


}





if (choice== 5 )
{
  //ex3    
    Console.WriteLine("goodbye");
}
    }while (choice <=4);// while statement for first do when we with the logic created here anything above 4 will end the program, and with the conditioning for "choice" this will cannot see anything above 5, meaning 5 is the only thing that shoulde break the loop. 
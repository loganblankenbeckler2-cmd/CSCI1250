/*
* Name: Logan Blankenbeckler
* Course: CSCI 1250, Section 002
* Assignment: Lab 08, Game Night
* Date: November 18, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/


using System.Drawing;

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;  

// look for the data files next to Program.cs , howevver the program is started. ( finding my files)
 string projectFolder = Path.GetFullPath(
    Path.Combine(AppContext.BaseDirectory, "..","..",".."));
Directory.SetCurrentDirectory(projectFolder);
 

Console.WriteLine("PLAYER ".PadRight(11) + "SCORE ");

string[] player = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);
int leaderIndex = 0;
double leadScore = 0 ; 
double totalPointsgrp = 0 ; 

for ( int i = 0 ; i < player.Length ; i++)// for loop is used so we can evaluate all items in arrays based per logic in this line - count controlled 
{
    Console.WriteLine(player[i].PadRight(11) + points[i]);


    double score = Convert.ToDouble(points[i]);
     totalPointsgrp = Convert.ToDouble(points[i]) + totalPointsgrp; 
    

    if (score > leadScore)// using if statement so logic can replace highest score stored above until the largest is found
    {
        leadScore = score;
        leaderIndex = i; 
    }

}
    
Console.WriteLine("Leader: " + player[leaderIndex] +  " with " + leadScore) ; 
Console.WriteLine("Season total: " + totalPointsgrp);

///---------END part one-------
/// 

int [] tonightScore = new  int[player.Length];
int tonightWinnerindex = 0 ;
int tonightHigh = 0 ; 


for (int i = 0 ; i < player.Length ; i++)// for loop is used so we can evaluate all items in arrays based per logic in this line - count controlled 
{
   Console.Write("points tonight for " + player[i] + ":" );
   tonightScore[i] = Convert.ToInt32(Console.ReadLine());

     while (tonightScore[i] < 0 || tonightScore[i] > MAX_POINTS)// using while loop so program will not proceed or increase [i] until the input is within the proper range - evaluates FIRST
        {
         Console.WriteLine("points must be from 0 to " + MAX_POINTS);
         Console.Write("points tonight for " + player[i] + ":" );
         tonightScore[i] = Convert.ToInt32(Console.ReadLine());

        }

    int seasonind = Convert.ToInt32(points[i]) + tonightScore[i];//math for adding individuals tonight points to all previous points stored n file
    points[i] = seasonind.ToString(); // converting the sums to string so they are formmatted points array. points array is string due to values being stored in .txt
 


    if (tonightScore[i] > tonightHigh)// using if statement so logic can replace highest score stored above until the largest is found
    {
        tonightHigh = tonightScore[i];
        tonightWinnerindex = i ;
    }
}

File.WriteAllLines(POINTS_FILE,points);// writing the new scores to file

Console.WriteLine("Tonights winner : " + player[tonightWinnerindex] + " with " + tonightHigh);
Console.WriteLine("\n");
Console.WriteLine("Saved points.txt.");

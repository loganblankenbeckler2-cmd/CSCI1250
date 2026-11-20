/*
* Name: Logan Blankenbeckler
* Course: CSCI 1250, Section 002
* Assignment: Lab 08, Game Night
* Date: November 18, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/


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
double totalPoints = 0 ; 

for ( int i = 0 ; i < player.Length ; i++)// for loop is used so we can evaluate all items in arrays based per logic in this line - count controlled
{
    Console.WriteLine(player[i].PadRight(11) + points[i]);


    double score = Convert.ToDouble(points[i]);
     totalPoints = Convert.ToDouble(points[i]) + totalPoints; 
    

    if (score > leadScore)// using if statement so logic can replace highest score stored above until the largest is found
    {
        leadScore = score;
        leaderIndex = i; 
    }

}
    
Console.WriteLine("Leader: " + player[leaderIndex] +  " with " + leadScore) ; 
Console.WriteLine("Season total: " + totalPoints);

///---------END part one-------
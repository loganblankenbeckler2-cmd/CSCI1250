/*
* Name: Logan Blankenbeckler
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
//---------------name,id, and locker info----------------------------------


Console.Write("students full name");

Random rng = new Random();

string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName= fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string nameOnbadge = firstName.ToUpper() +" "+ lastName.ToUpper();  

string fullLower = fullName.ToLower() ;

string fisrtInitial = firstName.Substring(0,1);

string lastInitial = lastName.Substring(0,1);

string upperFrsti = fisrtInitial.ToUpper();

string upperLsti = lastInitial.ToUpper();

string intitials = upperFrsti + "." + upperLsti + ".";

string userName = fisrtInitial.ToLower()+lastName.ToLower();

int lastNamelength = lastName.Length;





int studentID = rng.Next(100000, 1000000);
int lockerNum = rng.Next(1, 501);
int idChkDigit = (studentID % 9);




//---------------------------time to class calculations-------

//--input from student------
Console.WriteLine("all measurements are in freedom units aka "+"\"feet\"");

System.Console.WriteLine(" ");

Console.WriteLine("the dorms x coordinate?");
    int dormX1= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("the dorms y coordinate ?");
    int dormY1= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("the classroom x coordinate ?");
    int classX2= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("the calssroom y coordinate ?");
    int classY2= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("your walking speed in ft/s ?");
    double lollyGagRate = Convert.ToDouble(Console.ReadLine()); 
    

 // √( (x₂ − x₁)² + (y₂ − y₁)² )
 double dist2classRaw = Math.Sqrt( Math.Pow((dormX1 - classX2), 2) + Math.Pow((dormY1 - classY2), 2));

    
   
double seconds2classRaw = (dist2classRaw / lollyGagRate); 

double seconds2classRnd = Math.Round(seconds2classRaw);

double minutes2class = (seconds2classRnd / 60) ;

//--calc values for display below--------
double dispMin2class = (Math.Floor(minutes2class));

double dispSec2class = (Math.Floor(seconds2classRnd % 60));

double disDist = Math.Round(dist2classRaw, 1);

//---- unblock below for math trouble shooting---
//Console.WriteLine( dispMin2class + " minutes");
//Console.WriteLine(dispSec2class + " seconds"); 
//Console.WriteLine(seconds2classRaw + " allseconds")     ;// checking time math
//Console.WriteLine(dist2classRaw + " distance");// chekcing dist math



//-----------configuring badge/printout---------------------
//--student name and info print-----
System.Console.WriteLine("Name on Badge: " + nameOnbadge);
System.Console.WriteLine("Username: " + userName);
System.Console.WriteLine("Initials: " + intitials);
System.Console.WriteLine("last Name Length: " + lastNamelength );
System.Console.WriteLine(" ");

//--studend id and locker number-----

System.Console.WriteLine("student ID #:" + studentID);
System.Console.WriteLine("locker #: " + lockerNum);
System.Console.WriteLine(" ");
//--coordinates,distance, speed print------

Console.WriteLine("dorm x : " + dormX1);
Console.WriteLine("dorm y : " + dormY1);
Console.WriteLine("class x : " + classX2);
Console.WriteLine("class y :" + classY2);
System.Console.WriteLine(" ");

Console.WriteLine("Distance : " + disDist + " feet");
Console.WriteLine("WALK".PadRight(10) + dispMin2class + " minutes " + dispSec2class + " seconds");
System.Console.WriteLine(" ");



Console.WriteLine("==================================");
Console.WriteLine("        ETSU STUDENT BADGE        ");
Console.WriteLine("==================================");
Console.WriteLine("NAME".PadRight(10) + nameOnbadge);
Console.WriteLine("USERNAME".PadRight(10) + userName);
Console.WriteLine("ID".PadRight(10) + studentID+"-"+idChkDigit);
Console.WriteLine("LOCKER".PadRight(10) + lockerNum);
Console.WriteLine("WALK".PadRight(10) + dispMin2class + " min " + dispSec2class + " sec");
Console.WriteLine("==================================");
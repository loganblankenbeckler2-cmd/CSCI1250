//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();

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



System.Console.WriteLine("Name on Badge: " + nameOnbadge);
System.Console.WriteLine("Username: " + userName);
System.Console.WriteLine("Initials: " + intitials);
System.Console.WriteLine("last Name Length: " + lastNamelength);

int studentID = rng.Next(100000, 1000000);
int lockerNum = rng.Next(1, 501);

System.Console.WriteLine("student ID #:" + studentID);
System.Console.WriteLine("locker #: " + lockerNum);


//---------------------------time to class calculations-------

Console.WriteLine("all measurements are in freedom units aka "+"feet");
Console.WriteLine("the dorms x coordinate?");
    int dormX1= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("the ;dorms y coordinate ?");
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


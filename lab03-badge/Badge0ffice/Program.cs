//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();

Console.Write("students full name");


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

/*
* Name: Logan Blankenbeckler
* Course: CSCI 1250, Section 002
* Assignment: Lab 04, the group trip
* Date: october 13 2026
* Description: rebuilds trip calculator with methods and arrays so it reports on a whole group instead of one person.
*/

//-----arrays for names, hours worked and pay rate. elements are counted 0 through 3 for a total of 4. ada=0, grace=1, alan=2, katherin=3. hours worked and pay rate are in the same order and aligns with names array i.e (ada, 22, 13.5 and grace , 15 16.00 etc)
string[] names = {"ada", "grace", "Alan", "katherine"};

double[] hoursWorked = {22, 15, 30, 18};

double[] payRate = { 13.50, 16.00, 11.20, 14.80};


//------------ gathering user inputs----------------------

Console.WriteLine("what are the round trip miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the vehicles miles per gallon? ");
int milesPerGallon= Convert.ToInt32(Console.ReadLine()) ;

Console.Write("what is the gas price?");
double gasPrice= Convert.ToDouble(Console.ReadLine()); // double can hold decimal

Console.Write("How many pizza you gonna need?");
int pizzasNeeded= Convert.ToInt32(Console.ReadLine());

Console.Write("How much does each pizza Cost?");
double pricePerPie= Convert.ToDouble(Console.ReadLine());

//--------------------------------------------------------------

const int slicePerPie = 8 ; 

int totalSlices = slicePerPie * pizzasNeeded ;

double slicePerPerson= totalSlices / names.Length ;

double PizzaCost= pizzasNeeded * pricePerPie ; 


const double extortionRate= 18;

const double decCon= 100;

double fuelCost = FuelCostMeth(milesForTheTrip,milesPerGallon,gasPrice); // calling method calculations to use in trip total 
double fuelCostrnd= Math.Round(fuelCost,2);
double tripTotal= fuelCost + PizzaCost;// calculating trip total with fuel cost variable passed from method
double tripTotalrnd = Math.Round(tripTotal,2);
double costPerperson= tripTotal / names.Length ; 
double costPerpersonrnd = Math.Round(costPerperson,2);

//------- console outputs, for loop , and methods-------------

Console.WriteLine ("round trip miles: " + milesForTheTrip);
Console.WriteLine ("vehicle miles per gallon: " + milesPerGallon);
Console.WriteLine ("Price per gallon: " + gasPrice);
Console.WriteLine ("How many pizzas: " + pizzasNeeded);
Console.WriteLine ("pricer per pizza: " + pricePerPie + "\n");


Console.WriteLine ("===Part 1: The Trip===");
Console.WriteLine ("pizza cost: " + PizzaCost);
Console.WriteLine ("fuel cost:  " + fuelCostrnd );
Console.WriteLine ("trip total: " + tripTotalrnd + "\n");

Console.WriteLine ("===Part 2: The Group===");
Console.WriteLine ("people going : " + names.Length);
Console.WriteLine ("Slices each: " + slicePerPerson);
Console.WriteLine ("cost per person: " + costPerpersonrnd  + "\n");

Console.WriteLine ("===Part 3: who works how long===");

// ------place holder variables for values for running totals from for statement------
double totalHours = 0;

double longest = 0;

double takeHometotal = 0 ;



 ////------------------for loop--------------------   

for( int i = 0; i < names.Length; i++)// starting at index 0 (0 through 3 equalling 4), I++ adding one each pass until value for i is equal to index lenght (4). Below calculates utilizing values generated from below methods, and variables. above 3  variables are then updated with values calculated below. 
{
    double takeHomepay = takeHomepayMeth(hoursWorked[i], payRate[i], extortionRate);

    takeHometotal += takeHomepay;

    double takeHomeHr = takeHomepay / hoursWorked[i];

    double hoursRequired = HoursToCover(costPerperson, takeHomeHr);

    totalHours += hoursWorked[i];

    longest = Math.Max(longest, hoursRequired); 

    
//---- writing takehome pay, take home per hour, hours worked, and hours required for share for each person listedin array, will write line for each person untill above for contdition is met.----
    Console.WriteLine (names[i]+ ": takes home " + takeHomepay.ToString("C") + " for " + hoursWorked[i] + " hours worked, earns " + takeHomeHr.ToString("C") + " per hour after taxes, must work " + hoursRequired.ToString("F2") + " hours to cover their share"+ "\n") ;

   
    
}

double takeHometotalrnd = Math.Round(takeHometotal,2);
double longestRnd = Math.Round(longest,2); 

    Console.WriteLine ("total hours worked: " + totalHours);

    Console.WriteLine ("longest hours worked " + longestRnd);

    Console.WriteLine ("Take home total : " + takeHometotalrnd.ToString("C"));



//--------methods-----------------------------------------------------------------------------------
//---returns fuelCost
static double FuelCostMeth(double milesForTheTrip, double milesPerGallon, double gasPrice)// declaring method and paramter/variables used in calc
{
    double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;// performing calculations

    double fuelCost = gallonsNeeded * gasPrice; // performin calculations

    return fuelCost;// value to be passed outside of method / handing back fuel cost value
}
//-- returns takeHomepay
static double takeHomepayMeth ( double hoursWorked, double payRate, double extortionRate)// delaring method and paramters/variables used in calc
{
    double grossPay= hoursWorked * payRate ;// performing calculation

    double taxexWith= (extortionRate/decCon) * grossPay;// performing calcualtion

    double takeHomepay= grossPay - taxexWith ;// performing calculation

    return takeHomepay; // value to be passed outside of method // handing back take homepay value

}
//-- returns hoursRequired
static double  HoursToCover ( double costPerperson, double tkHomePayperhR)// declaring method and parameter/variables to be used in calculation
{
    double hoursRequired= costPerperson / tkHomePayperhR ;// performing calculation

    return hoursRequired ; // value to be passed outside of method / handing back hoursRequired calculation 
}
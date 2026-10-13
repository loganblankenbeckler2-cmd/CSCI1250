/*
* Name: Logan Blankenbeckler
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

//-----generating prompts for user inputs-------------------


Console.WriteLine( "===Part 1:Road Trip===");

Console.WriteLine("what are the round trip miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the vehicles miles per gallon? ");
int milesPerGallon= Convert.ToInt32(Console.ReadLine()) ;

Console.Write("what is the gas price?");
double gasPrice= Convert.ToDouble(Console.ReadLine()); // double can hold decimal









// doing math below. the two lines below are reading the data from the console.readline above and perfomring math functions. looks like they will be used further below



// generate outputs 


//System.Console.WriteLine("Gallons Needed: " + gallonsNeeded.ToString("F2"));// f2 =2 decomal plc

//System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));// c= doolar sign

// caluclating pizza party---------------------------
// gathering info about pizza and people
//const int slicePerPie = 8 ; 

//Console.WriteLine( "===Part 2:Pizza Party===");

//int peopleEating= Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizza you gonna need?");
int pizzasNeeded= Convert.ToInt32(Console.ReadLine());

Console.Write("How much does each pizza Cost?");
double pricePerPie= Convert.ToDouble(Console.ReadLine());

// doing the math for pizza party -------------------------

//int totalSlices = slicePerPie * pizzasNeeded ;

//double slicePerPerson= totalSlices / peopleEating ;

double PizzaCost= pizzasNeeded * pricePerPie ; 

// outputing the math----------------


//System.Console.WriteLine("Total slies: " + totalSlices.ToString("F2"));

//System.Console.WriteLine("Slices per person: " + slicePerPerson); 

//System.Console.WriteLine("Pizza Cost: " + PizzaCost.ToString("C")) ;

//---------paycheck----------
// getting input about working hours and pay 
//Console.WriteLine( "===Part 3: Paycheck===");

//Console.Write("How many hours did you work?");
//double hoursWorked= Convert.ToDouble(Console.ReadLine()) ;

//Console.Write("whats your hourly pay?");
//double payRate= Convert.ToDouble(Console.ReadLine());

//----doing math for pay----------------------------
const double extortionRate= 18;

const double decCon= 100;





//-----printing the output-----


//System.Console.WriteLine("Gross Pay:" + grossPay.ToString("C"));

//System.Console.WriteLine("Taxes Withheld: " + taxexWith.ToString("C"));

//System.Console.WriteLine("Take Home Pay: " + takeHomepay.ToString("C")) ; 

//----------calculating total cost--------------------------------


double fuelCost = FuelCostMeth(milesForTheTrip,milesPerGallon,gasPrice); // calling method calculations to use in trip total 
double tripTotal= fuelCost + PizzaCost;// calculating trip total with fuel cost variable passed from method
//double costPerperson= tripTotal / peopleEating ; 

//double tkHomePayperhR= takeHomepay / hoursWorked;



//------------printing final outputs-------------------------
//Console.WriteLine( "===Part 4: The Whold Trip===");



//System.Console.WriteLine("Cost per person: " + costPerperson.ToString("C"));

//System.Console.WriteLine("Take Home Pay per hour: " + tkHomePayperhR.ToString("C")) ; 

//System.Console.WriteLine("Hours you must work to cover your share:" + hoursRequired.ToString("F2"));
Console.WriteLine ("----part one----");
Console.WriteLine ("pizza cost " + PizzaCost);
Console.WriteLine ("fuel cost " + fuelCost );

Console.WriteLine ("trip total" + tripTotal);





//--------methods-----------

static double FuelCostMeth(double milesForTheTrip, double milesPerGallon, double gasPrice)// declaring method and paramter/variables used in calc
{
    double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;// performing calculations

    double fuelCost = gallonsNeeded * gasPrice; // performin calculations

    return fuelCost;// value to be passed outside of method 
}

static double takeHomepayMeth ( double hoursWorked, double payRate, double extortionRate)// delaring method and paramters/variables used in calc
{
    double grossPay= hoursWorked * payRate ;// performing calculation

    double taxexWith= (extortionRate/decCon) * grossPay;// performing calcualtion

    double takeHomepay= grossPay - taxexWith ;// performing calculation

    return takeHomepay; // value to be passed outside of method 

}

static double  HoursToCover ( double costPerperson, double tkHomePayperhR)// declaring method and parameter/variables to be used in calculation
{
    double hoursRequired= costPerperson / tkHomePayperhR ;// performing calculations

    return hoursRequired ; // value to be passed outside of method 
}
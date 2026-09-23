Console.WriteLine("what are the round trip miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the vehicles miles per gallon? ");
int milesPerGallon= Convert.ToInt32(Console.ReadLine()) ;

Console.Write("what is the gas price?");
double gasPrice= Convert.ToDouble(Console.ReadLine()); // double can hold decimal

// doing math below. the two lines below are reading the data from the console.readline above and perfomring math functions. looks like they will be used further below

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

// generate outputs 

System.Console.WriteLine("Gallons Needed: " + gallonsNeeded.ToString("F2"));// f2 =2 decomal plc
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));// c= doolar sign

// caluclating pizza party---------------------------
// gathering info about pizza and people
const int slicePerPie = 8 ; 

Console.Write("How many people are you feeding big dawg?");
int peopleEating= Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizza you gonna need?");
int pizzasNeeded= Convert.ToInt32(Console.ReadLine());

Console.Write("How much does each pizza Cost?");
double pricePerPie= Convert.ToDouble(Console.ReadLine());

// doing the math for pizza party -------------------------

int totalSlices = slicePerPie * pizzasNeeded ;
double slicePerPerson= totalSlices / peopleEating ;
double PizzaCost= pizzasNeeded * pricePerPie ; 

// outputing the math----------------
System.Console.WriteLine("Total slies: " + totalSlices.ToString("F2"));
System.Console.WriteLine("Slices per person: " + slicePerPerson); 
System.Console.WriteLine("Pizza Cost: " + PizzaCost.ToString("C")) ;

//---------paycheck----------
// getting input about working hours and pay 

Console.Write("How many hours did you work?");
double hoursWorked= Convert.ToDouble(Console.ReadLine()) ;

Console.Write("whats your hourly pay?");
double payRate= Convert.ToDouble(Console.ReadLine());

//----doing math for pay----------------------------
const double extortionRate= 18;
const double decCon= 100;
double grossPay= hoursWorked * payRate ;
double taxexWith= (extortionRate/decCon) * grossPay;
double takeHomepay= grossPay - taxexWith ;

//-----printing the output-----

System.Console.WriteLine("Gross Pay:" + grossPay.ToString("C"));
System.Console.WriteLine("Taxes Withheld: " + taxexWith.ToString("C"));
System.Console.WriteLine("Take Home Pay: " + takeHomepay.ToString("C")) ; 

//----------calculating total cost--------------------------------


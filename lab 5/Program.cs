//string[] names = {"mathew desjardins", "sally fields", "joe smith", "susan rice"};// array in string

System.Console.Write(" how many students do you want to ender ?");
int numStudents = Convert.ToInt32(Console.ReadLine());

if(numbStudents> 20)
{
    numStudents = 20;
}


// == equalt too != not equal too same as C++ for these logic operators, >= , <= equals go after the shark mouth
string[] names = new string[numStudents];

for(int i = 0; i < numbStudents; i++)
{
    // the first student sto be first 
    if(i == 0)
    {
    Console.Write($"Please enter the {i + 1}st students full name: "); // +1 is adding to the index number to account for caounting from zero
    }
    // secont to be secon 
    else if ( i == 1)
    {
         Console.Write($"Please enter the {i + 1}st students full name: ");
    }
    // thrid to be thrid
    else
    {
         Console.Write($"Please enter the {i + 1}rd students full name: ");
    }

    // foruth to be the nth 
  else
    {
     Console.Write($"Please enter the {i + 1}th students full name: ");
    }
}
string[] userNames= new string [names.Length];
int[] MakeStudenIds = MakeStudenIds(names.Length)

static int[] MakeStudenIds(int number)
{
    Random rng = new Random();
    int[] studentIds = new int [number];

    for(int i = 0 ; i < number; i++)
    {
        studentIds[i] = rng.Next(10000, 1000000); 
    }
    return studentIds;

}
names[i] = Console.ReadLine();







//--method for user names with for loop 
static string[] MakeUserNameList(string[] names)
{
    string userNames = new string[names.Length];



for(int i = 0; i < names.Length; i++)
{
    string[] splitUpName = names[i]. split();
    MakeUserName(splitUpName[0], splitUpName[1]);
    // splitUpName [0] = mathew // / 0 firstname
    // splitupName [1] = desjardins /// 1 lastname?
}// all for loops today will have same structur
 return userNames;
}
static string MakeUserName( string firstName, string lastName){
    string userName = fisrtName.ToLower.Trim()[0].ToString;
    usernName += lastName.ToLower().Trim;// makinguser name, converting to lower, and trimming to fit

}
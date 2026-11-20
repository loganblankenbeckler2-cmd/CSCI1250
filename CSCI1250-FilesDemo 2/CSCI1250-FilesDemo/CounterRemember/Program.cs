// The same counter, but the number lives in a file between runs.
const string COUNT_FILE = "runs.txt";

// Where the program itself lives: ...\StudyLog\bin\Debug\net10.0\
string programFolder = AppContext.BaseDirectory;

// Program.cs is three folders up from there.
string projectFolder = Path.GetFullPath(Path.Combine(programFolder, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] lines = File.ReadAllLines(COUNT_FILE);
int runs = Convert.ToInt32(lines[0]);

runs = runs + 1;
Console.WriteLine("This is run number " + runs + ".");

string[] output = { runs.ToString() };
File.WriteAllLines(COUNT_FILE, output);

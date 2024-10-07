Console.WriteLine("Enter number a");
int a = int.Parse(Console.ReadLine()); // Any integer will do

Console.WriteLine("Enter number b");
long b = int.Parse(Console.ReadLine()); // Has to be a long number

Console.WriteLine("Enter string"); // String 
string name = Console.ReadLine();

bool isTrue = true;  // Bool will show True

Console.WriteLine("Result of the inputs");

Console.WriteLine($"The output is: {a}");

Console.WriteLine($"The output is: {b}");

Console.WriteLine($"The output is: {name}");

Console.WriteLine($"The output is:{isTrue}");

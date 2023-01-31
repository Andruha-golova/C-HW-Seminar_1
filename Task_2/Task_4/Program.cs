System.Console.WriteLine("Enter numberA:");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter numberB:");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter numberC:");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if(numberB > numberA) max = numberB;
if(numberC > numberB) max = numberC;

System.Console.WriteLine($"The maximum number is:{max}");
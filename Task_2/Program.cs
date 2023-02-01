System.Console.WriteLine("enter number A:");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter number B:");  
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > numberB) max = numberA;
if (numberB > numberA) max = numberB;
System.Console.WriteLine($"The maximum number is:{max}");
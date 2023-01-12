// Welcome to the Distance Calculator by Will
#nullable disable
Console.Clear();
Console.WriteLine("WELCOME TO THE DISTANCE CALCULATOR");

// Input
Console.WriteLine("Enter the x1 Value: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the x2 Value: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the y1 Value: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the y2 Value: ");
double y2 = Convert.ToDouble(Console.ReadLine());

// Process
double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// Output
Console.WriteLine($"The Distance is : {dist}");

Console.WriteLine("Thanks For Using the Calculator");


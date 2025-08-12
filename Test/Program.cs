Console.WriteLine("Welcome to the Weight Calculator!");

System.Console.Write("Enter you gender(Male/Female): ");
string? gender = Console.ReadLine();

if (gender?.ToLower() == "male")
{
    Console.WriteLine("You have selected Male.");
}
else if (gender?.ToLower() == "female")
{
    Console.WriteLine("You have selected Female.");
}
else
{
    Console.WriteLine("Invalid gender selection.");
}

Console.Write("Enter your mass in kilograms: ");
string? massInput = Console.ReadLine();
double mass;
while (!double.TryParse(massInput, out mass) || mass <= 0)
{
    Console.Write("Invalid input. Please enter a positive number for mass: ");
    massInput = Console.ReadLine();
}

Console.Write("Enter gravity in m/s^2 (press Enter for Earth's gravity 9.81): ");
string? gravityInput = Console.ReadLine();
double gravity;
if (string.IsNullOrWhiteSpace(gravityInput))
{
    gravity = 9.81;
}
else
{
    while (!double.TryParse(gravityInput, out gravity) || gravity <= 0)
    {
        Console.Write("Invalid input. Please enter a positive number for gravity: ");
        gravityInput = Console.ReadLine();
    }
}

double weight = mass * gravity;
Console.WriteLine($"Your weight is {weight} Newtons.");

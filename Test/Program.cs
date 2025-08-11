Console.WriteLine("Welcome to the Weight Calculator!");

// Ask for mass in kilograms
Console.Write("Enter your mass in kilograms: ");
string? massInput = Console.ReadLine();
double mass;
while (!double.TryParse(massInput, out mass) || mass <= 0)
{
    Console.Write("Invalid input. Please enter a positive number for mass: ");
    massInput = Console.ReadLine();
}

// Ask for gravity (default to Earth's gravity if blank)
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

// Calculate weight
double weight = mass * gravity;
Console.WriteLine($"Your weight is {weight} Newtons.");

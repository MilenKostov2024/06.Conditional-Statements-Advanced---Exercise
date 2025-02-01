// Четене на входа
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string vacationType = "";
double spentAmount = 0.0;

// Избиране на дестинация според бюджета
if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        vacationType = "Camp";
        spentAmount = budget * 0.30;  // 30% през лятото
    }
    else  // зима
    {
        vacationType = "Hotel";
        spentAmount = budget * 0.70;  // 70% през зимата
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        vacationType = "Camp";
        spentAmount = budget * 0.40;  // 40% през лятото
    }
    else  // зима
    {
        vacationType = "Hotel";
        spentAmount = budget * 0.80;  // 80% през зимата
    }
}
else
{
    destination = "Europe";
    vacationType = "Hotel";
    spentAmount = budget * 0.90;  // 90% независимо от сезона
}

// Печатане на резултата
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{vacationType} - {spentAmount:F2}");
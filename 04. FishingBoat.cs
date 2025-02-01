// Четене на входните данни
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

// Определяне на цената на наема според сезона
double rentalPrice = 0;
if (season == "Spring")
{
    rentalPrice = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
    rentalPrice = 4200;
}
else if(season == "Winter")
{
    rentalPrice = 2600;
}

// Приложение на отстъпки според броя на рибарите
double discount = 0;
if (fishermen <= 6)
{
    discount = 0.10;
}
else if (fishermen <= 11)
{
    discount = 0.15;
}
else
{
    discount = 0.25;
}

// Приложение на допълнителна отстъпка за четен брой рибари (освен ако е есен)
if (fishermen % 2 == 0 && season != "Autumn")
{
    discount += 0.05;
}

// Изчисляване на цената след отстъпките
double finalPrice = rentalPrice * (1 - discount);

// Сравняване с бюджета
if (finalPrice <= budget)
{
    double remainingMoney = budget - finalPrice;
    Console.WriteLine($"Yes! You have {remainingMoney:F2} leva left.");
}
else
{
    double neededMoney = finalPrice - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
}
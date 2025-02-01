// Четене на вход
string flowerType = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());

// Цени на цветята
double pricePerFlower = 0;

switch (flowerType)
{
    case "Roses":
        pricePerFlower = 5;
        if (flowerCount > 80) pricePerFlower *= 0.90; // 10% отстъпка
        break;
    case "Dahlias":
        pricePerFlower = 3.80;
        if (flowerCount > 90) pricePerFlower *= 0.85; // 15% отстъпка
        break;
    case "Tulips":
        pricePerFlower = 2.80;
        if (flowerCount > 80) pricePerFlower *= 0.85; // 15% отстъпка
        break;
    case "Narcissus":
        pricePerFlower = 3;
        if (flowerCount < 120) pricePerFlower *= 1.15; // 15% оскъпяване
        break;
    case "Gladiolus":
        pricePerFlower = 2.50;
        if (flowerCount < 80) pricePerFlower *= 1.20; // 20% оскъпяване
        break;
    default:
        Console.WriteLine("error");
        return;
}

// Изчисляване на общата стойност
double totalCost = flowerCount * pricePerFlower;

// Проверка дали бюджета е достатъчен
if (totalCost <= budget)
{
    double remainingMoney = budget - totalCost;
    Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {remainingMoney:F2} leva left.");
}
else
{
    double neededMoney = totalCost - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
}
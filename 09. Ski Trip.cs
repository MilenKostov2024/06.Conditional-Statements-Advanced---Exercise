
// Входни данни
int days = int.Parse(Console.ReadLine()); // Дни за престой
string roomType = Console.ReadLine(); // Вид помещение
string feedback = Console.ReadLine(); // Оценка (positive/negative)

int nights = days - 1; // Броят нощувки = дни - 1
double pricePerNight = 0.0;

// Определяне на цената за нощувка
if (roomType == "room for one person")
{
    pricePerNight = 18.00;
}
else if (roomType == "apartment")
{
    pricePerNight = 25.00;
}
else if (roomType == "president apartment")
{
    pricePerNight = 35.00;
}

// Обща цена преди намалението
double totalPrice = nights * pricePerNight;

// Прилагане на намаление според броя нощувки
if (roomType == "apartment")
{
    if (days < 10)
        totalPrice *= 0.70; // 30% отстъпка
    else if (days <= 15)
        totalPrice *= 0.65; // 35% отстъпка
    else
        totalPrice *= 0.50; // 50% отстъпка
}
else if (roomType == "president apartment")
{
    if (days < 10)
        totalPrice *= 0.90; // 10% отстъпка
    else if (days <= 15)
        totalPrice *= 0.85; // 15% отстъпка
    else
        totalPrice *= 0.80; // 20% отстъпка
}

// Корекция според оценката
if (feedback == "positive")
{
    totalPrice *= 1.25; // Увеличение с 25%
}
else if (feedback == "negative")
{
    totalPrice *= 0.90; // Намаление с 10%
}

// Отпечатване на крайната цена
Console.WriteLine($"{totalPrice:F2}");

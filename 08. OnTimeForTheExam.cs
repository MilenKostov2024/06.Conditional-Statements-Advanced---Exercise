// Четене на входни данни
int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

// Преобразуваме часовете и минутите в минути от началото на деня
int examTime = examHour * 60 + examMinute;
int arrivalTime = arrivalHour * 60 + arrivalMinute;

// Изчисляваме разликата във времето
int timeDifference = arrivalTime - examTime;

if (timeDifference > 0)
{
    Console.WriteLine("Late");
}
else if (timeDifference >= -30)
{
    Console.WriteLine("On time");
}
else
{
    Console.WriteLine("Early");
}

// Ако има разлика във времето, я отпечатваме
if (timeDifference != 0)
{
    int absDifference = Math.Abs(timeDifference);
    int hours = absDifference / 60;
    int minutes = absDifference % 60;

    if (hours > 0)
    {
        Console.WriteLine($"{hours}:{minutes:D2} hours {(timeDifference > 0 ? "after" : "before")} the start");
    }
    else
    {
        Console.WriteLine($"{minutes} minutes {(timeDifference > 0 ? "after" : "before")} the start");
    }
}
// Price 
double PremierePrice = 12.00;
double NormalPrice = 7.50;
double DiscountPrice = 5.00;

//Input
string typeProjections = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int colums = int.Parse(Console.ReadLine());

//Calculations
double income = 0.0;

switch (typeProjections)
{
    case "Premiere":
        income = rows * colums * PremierePrice;
        break;
    case "Normal":
        income = rows * colums * NormalPrice;
        break;
    case "Discount":
        income = rows * colums * DiscountPrice;
        break;
}

//Output
Console.WriteLine($"{income:f2} lv");


Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLenght = 4.2;

double roomArea = roomWidth * roomLenght;
double roomPerimeter = (roomWidth + roomLenght) * 2;

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLenght} м");
Console.WriteLine ($"Площадь: {roomWidth} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");


Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;

double TotalWithInterest = laptopPrice * (1 + interestRate);
double monthsPayment = TotalWithInterest / monthsCount;

Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
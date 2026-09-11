string myName = "Монастырева Вероника";
string groupName = "ИСП-251";
int courseNumber = 2;
double averageGrade = 4.6;
bool isBuget = true;

Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBuget}");

// пустая строка, чтоб в терминале был отступ, после пишем заголовок, чтоб было понятно, что это за программа
Console.WriteLine();
Console.WriteLine("Ремонт: комната");

// ширина и длина комнаты, doubl потому что размеры берем с дробной частью
double roomWidth = 3.5;
double roomLenght = 4.2;

// считаем площадь, умножаем ширину на длину
double roomArea = roomWidth * roomLenght;
// считаем периметр, складывая ширинук и длину, после умножаем на 2
double roomPerimeter = (roomWidth + roomLenght) * 2;

// выводим на терминал ширину и длину, площадь и периметр
Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLenght} м");
Console.WriteLine ($"Площадь: {roomWidth} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");

// пустая строчка для отступа и название программы
Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

// цена ноутбука и срок рассрочки, пишем int потому что точные числа
int laptopPrice = 65000;
int monthsCount = 12;
// процентная ставка, число дробное, поэтому double
double interestRate = 0.08;

// считаем итоговую сумму (цена + проценты) и сколько надо платить каждый месяц (итоговую сумму делим на месяцы)
double TotalWithInterest = laptopPrice * (1 + interestRate);
double monthsPayment = TotalWithInterest / monthsCount;

// выводим цену ноутбука и итоговую сумму с процентами на терминале
Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {TotalWithInterest} руб.");

// пустая строка для отступа и пишем название программи
Console.WriteLine();
Console.WriteLine("Внимание: деление int");

// кол-во студентов и групп int потмоу что целовое число
int totalStudents = 25;
int groupCount = 4;
// делит int на int и получается целое число
int studentsPerGroupWrong = totalStudents / groupCount;
// превращаем одно число в double, чтобы получить результат с дробью, он будет более точным
double studentsPerGroupCorrect = (double)totalStudents / groupCount;
// показываем два результата. с делением на int и с double
Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double {studentsPerGroupCorrect}");


//пустая строка для отступа и название программь
Console.WriteLine();
Console.WriteLine("Способы собрать строку");
// пишем имя и фамилию
string firstName = "Вероника";
string lastName = "Монастырева";

//Способ 1: конкатенация через оператор +. пробел в кавычках нужен, чтобы фамилия и имя не слиплись
string fullNameConcat = firstName + " " + lastName;

//Способ 2: интерполяция через $"". способ удобнее, ведь не надо писать плюсф
string fullNameInterp = $"{firstName} {lastName}";

//Способ 3: метод string.Contact. тоже удобный способ, ведь тут просто через запятую перечисляем что надо склеить
string fullNameContactMetod = string.Concat(firstName, " ", lastName);
// выводим все результаты на терминале. && - озночает "и", а == - озночает "равно"
Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameContactMetod);
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameContactMetod}");


// пустая строка для отспупа и название программы
Console.WriteLine();
Console.WriteLine("Константы");

// НДС (налог на стоимость) - 20% поэтмоу double, const означает что число нельзя поменять
const double VatRate = 0.20;
// тут тоже const, ведь название колледжа неизменямое
const string CollegeName = "ВФ ВолГУ";

// цена товара без НДС (может меняться)
double productPrice = 1000;
// считаем цену с НДС цена + 20% 
double priceWithVat = productPrice * (1 + VatRate);

// выводим на терминале название коллежа, цену без НДС. савку на НДС и итоговую цену с НДС 
Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");


// Однострочный комментарий - до конца строки

/*
 Многострочный комментарий -
 может занимать несколько строк
 */

 // TODO: часто используется, чтобы отметить недоделанный участок кода

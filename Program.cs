using System.ComponentModel;
using System.Globalization;

int age = 20;
if (age >= 21) {
    Console.WriteLine("Доступ разрешён");
}
Console.WriteLine("Программа продолжает работу");

int age1 = 15;
if (age1 >= 18)
{
    Console.WriteLine("Доступ разрешён");
} else {
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"{18 - age1} лeт осталось ждать до совершеннолетия");
}

int age2 = 70;
if (age2 < 13)
{
    Console.WriteLine("Ребёнок");
} else if (age2 < 18) {
    Console.WriteLine("Подросток");
} else if (age2 >= 60) {
    Console.WriteLine("Пенсионер");
} else {
    Console.WriteLine("Взрослый");
}

int age3 = 16;
double height = 1.4;
bool adult = false;
if ((age3 >= 14 && height >= 1.5) || (adult == true && height <= 1.5))
{
    Console.WriteLine("Можно кататься");
} else
{
    Console.WriteLine("Пока нельзя");
}


int month = 8;
string monthName = "";
switch (month)
{
    case 6:
        monthName = "Июнь";
        break;
    case 7:
        monthName = "Июль";
        break;
    default:
        monthName = "Другой месяц";
        break;
}
Console.WriteLine(monthName);

int number = 5;
string result = (number >= 18) ? "взрослый" : "не  взрослый";
Console.WriteLine(result);

Console.WriteLine("Вариант Б");
int grade = 4;
string textGrade = "";
switch (grade)
{
    case 5:
        textGrade = "Отлично";
        break;
    case 4:
        textGrade = "Хорошо";
        break;
    case 3:
        textGrade = "Удовлетворительно";
        break;
    case 2:
        textGrade = "Неудовлетворительно";
        break;
    default:
        textGrade = "Неверная оценка";
        break;
}
Console.WriteLine(textGrade);

Console.WriteLine("Вариант Г");
int year = 2024;
string result1 = ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) ? "год високосный" : "год не високосный";
Console.WriteLine(result1);

Console.WriteLine("Вариант 5");
Console.Write("Введите сумму покупки: ");
double summ = double.Parse(Console.ReadLine());
if (summ > 1000)
{
    summ = summ - (summ * 0.1); // скидка 10%
}
else if (summ > 500)
{
    summ = summ - (summ * 0.05); // скидка 5%
} Console.WriteLine($"К оплате: {summ}");


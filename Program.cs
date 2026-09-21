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

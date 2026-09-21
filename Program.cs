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




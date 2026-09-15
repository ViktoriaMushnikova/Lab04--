Console.Write("Введите сумму покупки: ");
double summ = double.Parse(Console.ReadLine());
if (summ > 1000)
{
    summ = summ - (summ * 0.1);       // скидка 10%
}
else if (summ > 500)
{
    summ = summ - (summ * 0.05); // скидка 5%
} Console.WriteLine($"К оплате: {summ}");


Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double number2 = 1;

while (number2 <= number)
{
    if (number2%2==0)
    {
        Console.Write(number2 + " ");
    }
    number2++;
}

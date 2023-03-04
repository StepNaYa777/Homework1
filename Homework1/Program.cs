Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " > " + secondNumber);
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine(secondNumber + " > " + firstNumber);
}
else
{
    Console.WriteLine(secondNumber + " = " + firstNumber);
}
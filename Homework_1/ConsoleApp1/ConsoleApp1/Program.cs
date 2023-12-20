double a = double.Parse(args[0]);
string operation = args[1];
double b = double.Parse(args[2].Replace(".", ","));
switch (operation)
{
    case "+":
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        break;
    }
    case "-":
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    }
    case "*":
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    }
    case "/":
    {
        if(b == 0)
        {
            Console.WriteLine("Ошибка! Деление на ноль!");
        }
        else
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        break;
    }
    default:
    {
        Console.WriteLine($"Введена недопустимая операция: {operation}");
        break;
    }
}
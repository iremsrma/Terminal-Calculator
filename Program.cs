Console.WriteLine("Enter a number:");
string? input = Console.ReadLine();

decimal number = 0;
while (!decimal.TryParse(input, out number))
{
    Console.WriteLine("Invalid input! Enter a valid number:");
    input = Console.ReadLine();
}

Console.WriteLine("Enter an operator:");
string? op = Console.ReadLine();

while (op != "+" && op != "-" && op != "*" && op != "/")
{
    Console.WriteLine("Invalid operator! Please enter +, -, * or /");
    op = Console.ReadLine();
}

Console.WriteLine("Enter a number:");
string? input2 = Console.ReadLine();

decimal number2 = 0;
while (!decimal.TryParse(input2, out number2) || number2 == 0)
{
    Console.WriteLine("Invalid input! Enter a valid non-zero number:");
    input2 = Console.ReadLine();
}

decimal result = op switch
{
    "+" => number + number2,
    "-" => number - number2,
    "*" => number * number2,
    "/" => number / number2,
    _ => 0

};

Console.WriteLine(Math.Round(result, 4));
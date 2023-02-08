string input;
do
{
    Console.Write("Enter a number: ");
    input = Console.ReadLine()!;

    if (input != "quit")
    {
        int number = int.Parse(input);

        Console.WriteLine($"DigitIntoLongText: {DigitIntoLongText(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel1: {NumberIntoLongTextLevel1(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel2: {NumberIntoLongTextLevel2(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel3: {NumberIntoLongTextLevel3(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel4: {NumberIntoLongTextLevel4(number)}");
    }
}
while (input != "quit");

string DigitIntoLongText(int number)
{
    return number switch
    {
        0 => "zero",
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        5 => "five",
        6 => "six",
        7 => "seven",
        8 => "eight",
        9 => "nine",
        _ => "not a digit"
    };
}

string NumberIntoLongTextLevel1(int number)
{
    if (number < 10) { return DigitIntoLongText(number); }

    return number switch
    {
        10 => "ten",
        11 => "eleven",
        12 => "twelve",
        13 => "thirteen",
        15 => "fifteen",
        18 => "eighteen",
        <= 19 => $"{DigitIntoLongText(number % 10)}teen",
        _ => "not a valid number"
    };
}

string NumberIntoLongTextLevel2(int number)
{
    if (number < 20)
    {
        return NumberIntoLongTextLevel1(number);
    }

    string result = (number / 10) switch
    {
        2 => "twenty",
        3 => "thirty",
        4 => "forty",
        5 => "fifty",
        8 => "eighty",
        _ => $"{DigitIntoLongText(number / 10)}ty"
    };

    if (number % 10 != 0)
    {
        result += DigitIntoLongText(number % 10);
    }

    return result;
}

string NumberIntoLongTextLevel3(int number)
{

    if (number < 100)
    {
        return NumberIntoLongTextLevel1(number);
    }
    if (number > 999)
    {
        return "not a valid number";
    }

    string result = $"{DigitIntoLongText(number / 100)}hundred";

    if (number % 100 != 0)
    {
        result += NumberIntoLongTextLevel2(number % 100);
    }

    return result;
}

string NumberIntoLongTextLevel4(int number)
{
    if (number < 1000)
    {
        return NumberIntoLongTextLevel3(number);
    }
    if (number > 9999)
    {
        return "not a valid number";
    }

    string result = $"{DigitIntoLongText(number / 1000)}thousand";

    if (number % 1000 != 0)
    {
        result += NumberIntoLongTextLevel3(number % 1000);
    }

    return result;
}
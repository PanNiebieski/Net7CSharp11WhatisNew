
double[] numbers1 = new[] { 1.5, 0.5, 0.3 };
var r1_1 = MultiplyNumbersDou(numbers1);
var r1_2 = AddNumbersDou(numbers1);

int[] numbers2 = new[] { 9, 2, 3 };
var r2_1 = MultiplyNumbersInt(numbers2);
var r2_2 = AddNumbersInt(numbers2);

Console.WriteLine(r1_1);
Console.WriteLine(r1_2);
Console.WriteLine(r2_1);
Console.WriteLine(r2_2);

double MultiplyNumbersDou(double[] numbers)
{
    double result = 1;

    foreach (var item in numbers)
    {
        result *= item;
    }

    return result;
}

double AddNumbersDou(double[] numbers)
{
    double result = 0;

    foreach (var item in numbers)
    {
        result += item;
    }

    return result;
}

int MultiplyNumbersInt(int[] numbers)
{
    int result = 1;

    foreach (var item in numbers)
    {
        result *= item;
    }

    return result;
}

int AddNumbersInt(int[] numbers)
{
    int result = 0;

    foreach (var item in numbers)
    {
        result += item;
    }

    return result;
}

int ShowMax()
{
    return int.MaxValue;
}




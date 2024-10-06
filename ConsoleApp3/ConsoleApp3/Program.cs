int x1 = 1;
int x2 = 2;
double pi = 3.14;
string name = "Vlad";
var name2 = "Vlad";
bool isOlderThan18 = true;

for (var i = 0; i < 4; i = i + 1)
{
    // Console.WriteLine(i);
}

//                          0  1  2  3
int[] numbers = new int[] { 7, 2, 8, 0 };

var x = 2;
var xString = "2";

Console.WriteLine(numbers[2] == 8);

Console.WriteLine($"Привет, {name} name!");

for (var i = 0; i < 4; i = i + 1)
{
    if (numbers[i] > 5)
    {
        // Console.WriteLine("Число " + numbers[i] + " больше 5");
        Console.WriteLine($"Число {numbers[i]} больше 5");
    }
    else
    {
        // Console.WriteLine("Число " + numbers[i] + " не больше 5");
        Console.WriteLine($"Число {numbers[i]} не больше 5");
    }
}

var ost = 13 % 5; // 3
Console.WriteLine(ost);

for (var i = 0; i < 4; i = i + 1)
{
    if (numbers[i] % 2 == 0 || numbers[i] != 0)
    {
        Console.WriteLine($"Число {numbers[i]} четное");
    }
}

//                           0  1  2  3  4  5  6  7  8  9  10
int[] numbers2 = new int[] { 7, 2, 8, 0, 6, 3, 9, 7, 8, 1, 0 }; // 8 6 9 8
// Вывести все числа, которые больше предыдущего
for (int i = 0; i < numbers2.Length; i++)
{
    // if (i != 0 && numbers[i] > numbers[i - 1])
    // {
    //     Console.WriteLine(numbers[i]);
    // }
}


// var x = 13 % 5;
// x = 3

var n = 467;
var k = 0; // количество делителей

for (int i = 1; i <= n; i++)
{
    // Console.WriteLine($"Остаток от деления {n} % {i} = {n % i}");
    if (n % i == 0)
    {
        k++;
    }
}

if (k == 2)
{
    Console.WriteLine("Простое");
}
else
{
    Console.WriteLine("Не простое");
}

Sum(5, 6);

void Sum(int a, int b)
{
    Console.WriteLine(a + b);
}


// for (int i = 16; i < 23; i++)
// {
//     Console.WriteLine(i);
// }

// for (var i = 0; i < 4; i = i + 1)
// {
//     Console.WriteLine($"i = {i}; numbers[i] = {numbers[i]}");
// }
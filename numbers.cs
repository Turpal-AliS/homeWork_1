/*
// 1

float num_1 = 3.14f;
float num_2 = 42.0f;
double sum = num_1 + num_2;
Console.WriteLine(sum);
 */

/*
// 2

int numberOne = 33;
int numberTwo = 22;
int result = numberOne / numberTwo;
int remainder = numberOne % numberTwo;
Console.WriteLine($"При делении {numberOne} на {numberTwo} результат равен {result}, остаток равен {remainder}");
 */

/*
// 3.1

static void funcSign(int n)
{
    int fixNum = n * (-1);
    Console.WriteLine(fixNum);
}

Console.Write("Введите отрицательное число: ");
int i = int.Parse(Console.ReadLine());
funcSign(i);
 */

/*
// 3.2

static void func(int n)
{
    int sum = 0;
    if(n > 0)
    {
        for (int i = 0; i < n; n--)
        {
            sum += n;
        }
        Console.WriteLine(sum);
    }
    else
    {
        for (int i = 0; i > n; n++)
        {
            sum += n;
        }
        Console.WriteLine(sum);
    }
}
Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine());

func(x);
*/

/*

// 4

int month = 30;
int yearD = 360;
int yearM = 12;
int secondsInday = 86400;

Console.WriteLine("Введите пошагово день рождения, месяц рождения и год рождения");
int birthDay = int.Parse(Console.ReadLine());
int birthMonth = int.Parse(Console.ReadLine());
int birthYear = int.Parse(Console.ReadLine());

int today = 28;
int currentMonth = 2;
int currentYear = 2023;

int ageYear = (((currentYear * yearM - birthYear * yearM) - birthMonth + currentMonth) / yearM);
int ageMonth = (((((currentYear * yearM - birthYear * yearM) - birthMonth + currentMonth) % yearM) * month - birthDay + today)) / month;
int ageDay = (((((currentYear * yearM - birthYear * yearM) - birthMonth + currentMonth) % yearM) * month - birthDay + today)) % month;

// 4.2

Console.WriteLine($"{ageYear} years, {ageYear * yearM + ageMonth} month, {ageYear * yearD + ageMonth * month + ageDay} days and {ageYear * yearD * secondsInday + ageMonth * month * secondsInday + ageDay * secondsInday} seconds have passed since my birth");

// 4.3

if (birthMonth > 0 && birthMonth <= 3)
{
    Console.WriteLine("Вы родились в 1-м квартале");
}
else if (birthMonth > 3 && birthMonth <= 6)
{
    Console.WriteLine("Вы родились в 2-м квартале");
}
else if (birthMonth > 6 && birthMonth <= 9)
{
    Console.WriteLine("Вы родились в 3-м квартале");
}
else if (birthMonth > 9 && birthMonth <= 12)
{
    Console.WriteLine("Вы родились в 4-м квартале");
}

else
{
    Console.WriteLine("Возможно, вы ввели данный не корректно!");
}
 */

/*-----------------------------------------------------------------------------------------------------------*/

/*
 
int[] setOne = {1, 2, 3};
int[] setTwo = {3, 4, 5};

var result = setOne.Intersect(setTwo);

foreach (int s in result)
    Console.WriteLine(s); 

Console.WriteLine("----------------------------------------------------------------------------------------");

var resultSecond = setOne.Except(setTwo);
var resultSecondS = setTwo.Except(setOne);
var resultSecondSS = resultSecond.Union(resultSecondS);

foreach (int s in resultSecondSS)
    Console.WriteLine(s);

Console.WriteLine("-----------------------------------------------------------------------------------------");

var resultThird = setOne.Union(setTwo);

foreach (int s in resultThird)
    Console.WriteLine(s);

Console.WriteLine("-------------------------------------------------------------------------------");

var resultFourth = setOne.Except(setTwo);

foreach (int s in resultFourth)
    Console.WriteLine(s);

 
*/


/*
 
class Transformations {
    public static List<T> toSet<T>(T[] arr)
    {
        
        List<T> list = arr.ToList();

        return list;

    }
}

*/


static (int min, int max) MinMAx(HashSet<int> set)
{
    int min = int.MaxValue;
    int max = int.MinValue;
    foreach (int i in set)
    {
        if (i > min)
        {
            min = i;
        }

       else if (i < max)
        {
            max = i;
        }

    }
    return (min, max);
}

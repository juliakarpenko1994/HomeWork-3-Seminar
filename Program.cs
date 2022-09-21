/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

System.Console.Write("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());

int d1 = n / 10000;
n = n - d1 * 10000;

int d2 = n / 1000;
n = n - d2 * 1000;

int d3 = n / 100;
n = n - d3 * 100;

int d4 = n / 10;
n = n - d4 * 10;

int d5 = n % 10;

if (d1 == d5 && d2 == d4)
{
    System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не палиндром");
}*/

/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

int x1=3;
int y1=6;
int z1=8;

int x2=2;
int y2=1;
int z2=-7;

double distance=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+ Math.Pow(z1-z2,2));

System.Console.WriteLine(distance);*/


/*Задача 23 Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

int n = 3;
for (int i = 0; i <= n; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}
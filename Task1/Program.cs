Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int n1 = num % 10; //последняя цифра 
int n2 = num / 10;
int n3 = n2 % 10;// предпоследняя цифра
int n4 = num / 10000; //первая цифра 
int n5 = num / 1000;
int n6 = n5 % 10;// вторая цифра 
if (n1 == n4 && n3 == n6)
{
    Console.WriteLine("Ваше число: " +num + " - палиндром.");
}
else
{
    Console.WriteLine("Ваше число: " +num + " - не палиндром.");
}


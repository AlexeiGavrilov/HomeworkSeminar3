Console.WriteLine("Введите количество элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[N];
for (int i = 0; i < N; i++ )
{

    arr[i] = i*i*i;
}

void End(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write(array[i]+ "  ");
}
}
 End(arr);





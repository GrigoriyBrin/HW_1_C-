int[] N = {1, 2, 3, 4, 5};
int a = N.Length;
int index = 0;

while (N[index] < a)
{
    if (N[index] % 2 == 0)
    {
        Console.WriteLine(N[index]);
    }
   index++;
   
}
    
Console.WriteLine("Введите произвольное целое число больше 1");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.WriteLine();

if(a > 1)
{
    while(count < a)
    {
        if(count % 2 == 0)
        {
            Console.WriteLine(count);
        }
        count++;
    }
}

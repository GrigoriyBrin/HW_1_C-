Console.WriteLine("Введите произвольное целое число");
int a = Convert.ToInt32(Console.ReadLine());

int b = 2; 
int c = a % b;

if (c == 0)
{
    Console.WriteLine("Да");
}

else
{   
    Console.WriteLine("Нет");
}   

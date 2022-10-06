Console.WriteLine("Введите число, получите чётные от 1 до числа");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<=a)
{
    if (i%2==0)
    Console.WriteLine(i);
    i++;
}
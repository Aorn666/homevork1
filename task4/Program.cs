Console.WriteLine("Введите 3 числа и узнайте какое больше");
int max = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (max < b)
 max = b;
if (max < c)
 max = c;
 Console.WriteLine(max); 
/*
## primer05
Кегли
N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. Затем по этому ряду 
бросили K шаров, при этом i-й шар сбил все кегли с номерами от li до ri включительно. 
Определите, какие кегли остались стоять на месте.

Программа получает на вход количество кеглей N и количество бросков K. 
Далее идет K пар чисел li, ri, при этом 1≤ li≤ ri≤ N.
Программа должна вывести последовательность из N символов, где j-й символ есть “I”, 
если j-я кегля осталась стоять, или “.”, если j-я кегля была сбита.
Ссылка https://pythontutor.ru/lessons/lists/problems/kegelbahn/
*/
Console.Write("Введите количество кеглей: ");
int n_keg = int.Parse(Console.ReadLine());
Console.Write("Введите количество бросков: ");
int n_brs = int.Parse(Console.ReadLine());
string[] bowl = new string[n_keg];
int keg_min=0;
int keg_max=0;
int keg_temp=0;
for (int i = 0; i < n_keg; i++)
{
    bowl[i]="I";
}
/* Бросаем кегли */ 
for (int i = 0; i < n_brs; i++)
{
    keg_max = new Random().Next(1,n_keg);
    keg_min = new Random().Next(1,n_keg);
    if (keg_max < keg_min)
    {
      keg_temp = keg_min;
      keg_min  = keg_max;
      keg_max  = keg_temp;
      
    }
    for (int j = keg_min-1; j <= keg_max-1; j++)
    {
        bowl[j]=".";
    }
Console.WriteLine("Бросок №: "+i);
Console.WriteLine("Сбиваем кегли с "+keg_min+" по "+keg_max);
Console.WriteLine(String.Join("",bowl));
}
Console.WriteLine("Итог ");
Console.WriteLine(String.Join("",bowl));
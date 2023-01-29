/*
Дано действительное положительное число a и целое неотрицательное число n. 
Вычислите an не используя циклы, возведение в степень через ** и функцию math.pow(), 
а используя рекуррентное соотношение an=a⋅an-1.
Решение оформите в виде функции power(a, n).
*/
double power(int a, int n)
{
  double an=1;
  if (n >= 1) {  an = a * power( a, n-1); }
  return an;
}
double result = 0;
Console.Write("Введите  число: ");
int n_1 = int.Parse(Console.ReadLine());
Console.Write("Введите  степень: ");
int n_2 = int.Parse(Console.ReadLine());
result = power(n_1, n_2);
 Console.WriteLine(result);
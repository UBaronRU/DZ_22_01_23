/*
## primer03 
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int[] CreateMas(int n, int begin_n, int end_n){
    int[] arr = new int[n];
    for(int i =0;i<n;i++)
        arr[i]=new Random().Next(begin_n,end_n);
    return arr;
}
void PrintMas(int[] arr){
    Console.WriteLine(String.Join(" ",arr));
}


Console.WriteLine("Начало");
Console.WriteLine();
int razmer = new Random().Next(5,20);
int qty_max = 0;
int qty_min = 0;
int delta = 0;
int[] arry_1;
arry_1 = CreateMas(razmer,-254,254);
qty_max = arry_1[0];
qty_min = arry_1[0];
for (int i = 1; i < razmer; i++)
{
    if (arry_1[i] > qty_max)  {qty_max = arry_1[i];}
    if (arry_1[i] < qty_min)  {qty_min = arry_1[i];}
    
 }
PrintMas(arry_1);
delta = qty_max-qty_min;
Console.WriteLine(qty_max);
Console.WriteLine(qty_min);
Console.WriteLine(delta);

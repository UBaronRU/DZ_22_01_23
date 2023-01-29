/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
int qty_chet = 0;
int[] arry_1;
arry_1 = CreateMas(razmer,-254,254);

for (int i = 1; i < razmer; i=i+2)
{
    qty_chet=qty_chet+arry_1[i];
 }
PrintMas(arry_1);
Console.WriteLine(qty_chet);
/*
## primer04
Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]
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
int razmer = new Random().Next(10,40);
int[] arry_1;
arry_1 = CreateMas(razmer,1,25);
for (int i = 1; i < razmer; i++)
{
    if (arry_1[i] == 20)  
    {
        arry_1[i] = 200;
        Console.WriteLine(i);
        Console.WriteLine(arry_1[i]);
        i=razmer;
    }
    
    
 }
PrintMas(arry_1);

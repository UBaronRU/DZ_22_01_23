//## primer01  
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
arry_1 = CreateMas(razmer,100,1000);

for (int i = 0; i < razmer; i++)
{
 if  (arry_1[i]%2 == 0)
 {
    qty_chet++;
 }
}
PrintMas(arry_1);
Console.WriteLine(qty_chet);
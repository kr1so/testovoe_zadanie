// 2. Задача 
// 1. Алгоритм, заполняющий список произвольными целыми чистыми. 
// Получить новый список из элементов исходного, которые удовлетворяют условиям
// Элемент не кратен 2

int[] arrayA = new int[10];
int[] FillRandomArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++){
        array1[i] = new Random().Next(0, 15);
    }
    return array1;
}
void PrintArray(int[] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++){
        Console.Write($"{arrayPrint[i]} ");
    }
}
FillRandomArray(arrayA);
PrintArray(arrayA);
// Новый список из элементов исходного, который удовлетворяют условию
// Элемент не кратен 2
int EqualityThree(int[] array)
{
    for (int i = 0; i < array.Length; i++){
        if (array[i] ! % 2 == 0) return array[i];
    }
    return 0;
}
System.Console.WriteLine(EqualityThree(arrayA));
System.Console.WriteLine();
PrintArray(arrayA);
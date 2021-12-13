// 2. Задача 

// 1. Алгоритм, заполняющий список произвольными целыми чистыми. 
// Получить новый список из элементов исходного, которые удовлетворяют условиям
// Элемент кратен 3


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
// Элемент кратен 3


int[] array2 = new int [10];

int[] EqualityThree(int[] array)
{
    for (int i = 0; i < array.Length; i++){

            if (array[i] % 3 == 0) {
                return array2;
            }
            
    }
    return array;
}
array2= EqualityThree(arrayA);
System.Console.WriteLine();
PrintArray(array2);
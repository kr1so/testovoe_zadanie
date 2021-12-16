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
    System.Console.WriteLine();
}
FillRandomArray(arrayA);
PrintArray(arrayA);
int count = arrayA.Length;
int[] arrayB = new int [count];
int[] EqualityThree(int[] array, int[] array2){
    int j = 0;
    for (int i = 0; i < array.Length; i++){
       
            if (~ array[i]%2 == 0){
                array2[j] = array[i];
                j++;
            }
            array[i]++;
        }
            return array2;
    }
EqualityThree(arrayA, arrayB);
PrintArray(arrayB);


int[] arrayA = new int[100];
int[] arrayB = new int[100];
string FillRandomArray(int[] array1, int[] array2)
{
    string x = string.Empty;
    System.Console.WriteLine($"Первый список: ");
    for (int i = 0; i < array1.Length; i++){
        array1[i] = new Random().Next(10, 200);
        System.Console.Write($"{array1[i]} ");
    }
    System.Console.WriteLine($"\nВторой список: ");
    for (int j = 0; j < array2.Length; j++){
        array2[j] = new Random().Next(10, 200);
        System.Console.Write($"{array2[j]} ");
    }
    return x;
}
System.Console.WriteLine(FillRandomArray(arrayA, arrayB));
System.Console.WriteLine($"Присутствуют в обоих списках:");
var result = arrayA.Intersect(arrayB);
foreach (int s in result)
Console.Write($"{s} ");

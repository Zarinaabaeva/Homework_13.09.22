double[] GenerateArray(double length)
{ 
   double[] myArray = new double[] {63.5, 17.8, 222.9, 12.7, 788.3};

    return myArray;  
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }  
}
        
double maxMinArray(double[] arr)
{
 double max = arr.Max();
 double min = arr.Min();
 double difference = max - min;
 return difference;
}

var arr = GenerateArray(5);
PrintArray(arr);
var result = maxMinArray(arr);
Console.WriteLine($"разница между максимальным и минимальным значением -> {result}");





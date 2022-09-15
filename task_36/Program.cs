
int[] GenerateArray(int length)
{ 
   int[] myArray = new int[length];

    for (int i = 0; i < myArray.Length; i++)
    {
      myArray[i] = new Random().Next(10, 100);
    }
    return myArray;  
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }  
}
        
int sumOddIndexArray(int[] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
   if(i % 2 != 0)
     sum = sum + arr[i];
  }
  return sum;
}

var arr = GenerateArray(10);
PrintArray(arr);
var result = sumOddIndexArray(arr);
Console.WriteLine($"-> {result}");

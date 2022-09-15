int[] GenerateArray(int length)
{ 
   int[] myArray = new int[length];

    for (int i = 0; i < myArray.Length; i++)
    {
      myArray[i] = new Random().Next(100, 999);
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
        
int evenArray(int[] arr)
{
   int count = 0;
   for(int i = 0; i < arr.Length; i++)
   {
   if(arr[i] % 2 == 0)
   count++;
   }
      return count;
   }
   
var arr = GenerateArray(10);
PrintArray(arr);
var result = evenArray(arr);
Console.WriteLine($"-> {result}");

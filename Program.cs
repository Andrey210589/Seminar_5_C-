// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.

// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue +1);

//     }return array;
// }
// void ShowArray(int[]array)
// {
//     for( int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// int GetNegativeSum(int[]array)
// {
//     int sum = 0;
//     for(int i = 0 ;i < array.Length; i++)
//     if(array[i] < 0)
//     sum += array[i]; //То же самое что  и sum = sum + array[i];
//     return sum;
// }
// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = createRandomArray(size, min, max);
// int result = GetNegativeSum(newArray);
// ShowArray(newArray); 
// Console.WriteLine("Sum of negative elements is " + result);

// Напишите программу замена элементов массива: 
// положительные элементы замените 
// на соответствующие отрицательные,и наоборот. 

// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue +1);
//         return array;
// }
// void ShowArray(int[]array)
// {
//     for( int i = 0; i < array.Length; i++)
//         Console.Write(" " + array[i] + " ");
//         Console.WriteLine();
// }
// int[] ChengeNegativElements(int[]array)
// {  
//     for(int i = 0 ;i < array.Length; i++)
//         array[i] *= -1;
//     return array;
// }
// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = createRandomArray(size, min, max);
// int[] result = ChengeNegativElements(newArray);
// ShowArray(newArray); 
// ChengeNegativElements(newArray);
// ShowArray(result);


// Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue +1);
//     return array;
// }
// void ShowArray(int[]array)
// {
//     for( int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// bool FoundNum(int[]array, int num)
// {  
//     for(int i = 0 ;i < array.Length; i++)
//         if(array[i] == num)
//             return true;
//     return false;    
// }
// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] newArray = createRandomArray(size, min, max);
// bool result = FoundNum(newArray, num);
// ShowArray(newArray); 
// Console.WriteLine( result);


// Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [a,b].

// int[] createRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue +1);

//     }return array;
// }
// void ShowArray(int[]array)
// {
//     for( int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
// }
// int FoundNum(int[]array, int numA, int numB)
// {  int count = 0;
//     for(int i = 0 ;i < array.Length; i++)
//         if(array[i] >=numA && array[i] <= numB )
//             count++;
//     return count;
// }
// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = createRandomArray(size, min, max);
// Console.WriteLine("Input A ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int result = FoundNum(newArray, numA, numB);
// ShowArray(newArray); 
// Console.WriteLine( result);


// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.


int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}
void ShowArray(int[]array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

int[] FoundNum(int[]array)
{  
    int[] newArray = new int [array.Length / 2];
    for(int i = 0 ;i < newArray.Length ; i++)
        newArray[i] = array[i] * array[array.Length -1 - i];
    return newArray; 
}
Console.WriteLine("Input array size ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = createRandomArray(size, min, max);
int[] result = FoundNum(newArray);
ShowArray(newArray); 
Console.WriteLine();
ShowArray(result);



//int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//bool LinearSearch(int[] array , int key)
//{
//	for (int i = 0; i < array.Length; i++)
//	{
//		if (array[i] == key)
//		{
//			return true;
//		}
//	}
//	return false;
//}

//Console.WriteLine(LinearSearch(array, 4));

// linkedin
//Node nodeA= new Node();
//nodeA.Data = 865;

//Node nodeB= new Node();
//nodeB.Data = 344;

//Node nodeC= new Node();
//nodeC.Data = 888;

//Node nodeD= new Node();
//nodeD.Data = 222;

//nodeA.Next= nodeB;
//nodeB.Next= nodeC;
//nodeC.Next= nodeD;

//using DataAlgorithms.Stack;



//LinkedinList linkedinList = new LinkedinList();

//linkedinList.InsertFirst(1);
//linkedinList.InsertFirst(2);
//linkedinList.InsertFirst(3);
//linkedinList.InsertFirst(4);

//linkedinList.DeleteFirst();
//linkedinList.DeleteFirst();

//linkedinList.InsertLast(546);

//linkedinList.InsertLast(3434);

//linkedinList.DisplayList();


//Stack stack = new Stack(10);
//for (int i = 0; i < 3; i++)
//{
//    stack.Push("Squirtle");

//    stack.Push("Pickachu");

//    stack.Push("Charmander");
//}

//stack.Pop();
//stack.Peek();

//while (!stack.isEmpty())
//{
//   var var = stack.Pop();   
//   Console.WriteLine(var);
//}

//    queue  

//using DataAlgorithms.NewFolder;

//Queue queue = new Queue(10);

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);

//queue.Enqueue(4);

//queue.Dequeue();
//queue.Dequeue();

//queue.Peek();


// binarySearch

//int[] intArray =  { -22, -15, 2, 7, 20, 30, 54 };


//Console.WriteLine(BinarySearch(intArray,30));

//// start end + while less than is going criss crossing 
//int BinarySearch(int[] intArray,int value)
//{
//    int start = 0;
//    int end = intArray.Length;
//    while (start < end)
//    {
//        int midpoint = (start + end) / 2;

//        if (intArray[midpoint] == value)
//        {
//            return midpoint;
//        }
//        else if (intArray[midpoint] < value)
//        { 
//            start= midpoint+1;
//        }
//        else
//        {
//            end= midpoint;
//        }
//    }
//    return -1;
//}

// BinarySearchTree

//using DataAlgorithms.BinarySearchTree;

//BinarySearchTree bst = new BinarySearchTree();

//bst.Insert(7, "Squirtle");
//bst.Insert(23, "Ekans");
//bst.Insert(151, "Mew");
//bst.Insert(4, "Charmanger");
//bst.Insert(1, "Bulbasaur");

//Console.WriteLine(bst.Find(151));

//int value = 0;

// Buble Sort

//int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

//Console.WriteLine(BubbleSort(intArray));

//int [] BubbleSort(int[] intArray)
//{
//    int temp = 0;
//    for (int pointer = 0; pointer < intArray.Length; pointer++)
//    {
//        //Forms the 'box' that does the comparison
//        for (int   = 0; sort < intArray.Length-1; sort++)
//        {
//            if (intArray[sort] > intArray[sort + 1])
//            {
//                temp=intArray[sort+1];
//                intArray[sort+1] = intArray[sort];
//                intArray[sort] = temp;
//            }
//        }
//    }
//    return intArray;
//}
//IterativeFactorial(5);
//int IterativeFactorial(int num)
//{
//    if (num == 0)
//    {
//        return 1;
//    }

//    int factorial = 1;
//    for (int i = 1; i < num; i++)
//    {
//        factorial = factorial * i;
//    }
//    return factorial;
//}

//Console.WriteLine(RecursiveFactorial(5));
//int RecursiveFactorial(int num)
//{
//    if (num == 0) { return 1; }

//    return num * RecursiveFactorial(num - 1);
//}

// HashTable

//using DataAlgorithms.HashTable;

//HashTable hashTable = new HashTable();
//hashTable.Set("Teddy", "656-778-4949");
//hashTable.Set("Fırat", "313-451-3233");
//hashTable.Set("Patty", "313-213-3223");
//hashTable.Set("Sarah", "123-213-3232");
//hashTable.Set("Jennifer", "324-231-5435");


//Console.WriteLine(hashTable.Get("Teddy"));
//Console.WriteLine(hashTable.Get("Fırat"));
//Console.WriteLine(hashTable.Get("Patty"));
//Console.WriteLine(hashTable.Get("Sarah"));
//Console.WriteLine(hashTable.Get("Jennifer"));

using System;

class Program
{
    //static void ExchangeSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    for (int i = 0; i < n - 1; i++)
    //    {
    //        for (int j = i + 1; j < n; j++)
    //        {
    //            if (arr[i] > arr[j]) // Swap if current element is greater than the next element
    //            {
    //                int temp = arr[i];
    //                arr[i] = arr[j];
    //                arr[j] = temp;
    //            }
    //        }
    //    }
    //}

    //static void Main()
    //{
    //    int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
    //    Console.WriteLine("Original Array: " + string.Join(", ", numbers));

    //    ExchangeSort(numbers);
    //    Console.WriteLine("Sorted Array (Exchange Sort): " + string.Join(", ", numbers));
    //}
    //static void SelectionSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    for (int i = 0; i < n - 1; i++)
    //    {
    //        int minIndex = i;

    //        for (int j = i + 1; j < n; j++)
    //        {
    //            if (arr[j] < arr[minIndex])
    //                minIndex = j; // Update the index of the smallest element
    //        }

    //        if (minIndex != i)
    //        {
    //            int temp = arr[i];
    //            arr[i] = arr[minIndex];
    //            arr[minIndex] = temp;
    //        }
    //    }
    //}

    //static void Main()
    //{
    //    int[] numbers = { 64, 25, 12, 22, 11 };
    //    Console.WriteLine("Original Array: " + string.Join(", ", numbers));

    //    SelectionSort(numbers);
    //    Console.WriteLine("Sorted Array (Selection Sort): " + string.Join(", ", numbers));
    //}
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] numbers = { 12, 11, 13, 5, 6 };
        Console.WriteLine("Original Array: " + string.Join(", ", numbers));

        InsertionSort(numbers);
        Console.WriteLine("Sorted Array (Insertion Sort): " + string.Join(", ", numbers));
    }
}








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
using DataAlgorithms.ADT.Linkedin;



LinkedinList linkedinList = new LinkedinList();

linkedinList.InsertFirst(1);
linkedinList.InsertFirst(2);
linkedinList.InsertFirst(3);
linkedinList.InsertFirst(4);

linkedinList.DeleteFirst();
linkedinList.DeleteFirst();

linkedinList.InsertLast(546);

linkedinList.InsertLast(3434);

linkedinList.DisplayList();







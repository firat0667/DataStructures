using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAlgorithms.Stack
{
    public class Stack
    {
        public int MaxSize {  get; set; }

        // this holds our array;

        public string[] StackArray {  get; set; } 

        // this keeps track of the top 

        public int Top { get; set; }

        public Stack(int size) 
        {
            // this holds constructor value
           MaxSize = size;
            // create array with size 
           StackArray = new string[MaxSize];
            // we give the top -1 because array is zero index; if we dont 
            // it will skip first element
           Top = -1;
        }

        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }

        public string Pop()
        {
            //think placeholder
            int old_top=Top;
            // decreöemt for the new top
            Top--;
            return StackArray[old_top];

        }
        public string Peek()
        {
             return StackArray[Top];
        }
        public bool isEmpty()
        {
            return Top == 0;
        }
        public  bool isFull()
        {
            return (MaxSize -1== Top);
        }

    }
}

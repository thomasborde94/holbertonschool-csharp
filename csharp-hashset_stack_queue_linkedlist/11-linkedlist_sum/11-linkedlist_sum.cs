using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        LinkedListNode<int> current = myLList.First;
        int sum = 0;
        while (current != null)
        {
            sum += current.Value;
            current = current.Next;
        }
        return sum;
    }
}
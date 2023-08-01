using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        LinkedListNode<int> current = myLList.First;
        for (int index = 0; current != null; index++)
        {
            if (current.Value == value)
            {
                return index;
            }
            current = current.Next;
        }
        return -1;
    }
}
using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        for (int index = 0; current != null; index++)
        {
            if (index == n)
            {
                return current.Value;
            }
            current = current.Next;
        }
        return 0;
    }
}
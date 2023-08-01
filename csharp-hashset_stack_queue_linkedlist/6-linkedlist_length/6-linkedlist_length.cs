using System;
using System.Collections.Generic;
class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        LinkedListNode<int> current = myLList.First;
        int length = 0;
        for (int i = 1; current != null; i++)
        {
            current = current.Next;
            length = i;
        }
        return length;
    }
}

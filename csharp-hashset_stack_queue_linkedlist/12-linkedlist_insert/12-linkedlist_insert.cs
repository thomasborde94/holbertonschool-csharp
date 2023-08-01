using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        while (current != null)
        {
            if (n > current.Value && n < current.Next.Value)
                myLList.AddAfter(current, n);
            else
                current = current.Next;
        }
        return newNode;
    }
}
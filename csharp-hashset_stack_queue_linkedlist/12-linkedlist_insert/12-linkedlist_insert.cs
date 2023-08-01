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
            // If n is the smallest value
            if (current.Value == myLList.First.Value)
                if (n < current.Value)
                {
                    myLList.AddBefore(current, newNode);
                    break;
                }

            // If n is the biggest value
            if (n > current.Value && current.Next == null)
            {
                myLList.AddAfter(current, newNode);
                break;
            }

            // If n has a value of an already existing node
            if (n == current.Value)
            {
                myLList.AddAfter(current, newNode);
                break;
            }
            // Any other case
            if (n > current.Value && n < current.Next.Value)
            {
                myLList.AddAfter(current, newNode);
                break;
            }
            current = current.Next;
        }
        return newNode;
    }
}
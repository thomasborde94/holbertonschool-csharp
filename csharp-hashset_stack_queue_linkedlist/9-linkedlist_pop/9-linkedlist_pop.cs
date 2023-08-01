using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
            return 0;
        LinkedListNode<int> headNode = myLList.First;
        int headNodeValue = headNode.Value;
        myLList.RemoveFirst();
        return headNodeValue;
    }
}

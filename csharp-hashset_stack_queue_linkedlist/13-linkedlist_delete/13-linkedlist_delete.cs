﻿using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        for (int i = 0; current != null; i++)
        {
            if (i == index)
                myLList.Remove(current);
            current = current.Next;
        }
    }
}
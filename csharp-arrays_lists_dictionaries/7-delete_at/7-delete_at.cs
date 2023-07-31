using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index > myList.Count - 1)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        for (int i = index; i < myList.Count - 1; i++)
        {
            myList[i] = myList[i + 1];
            if (i == myList.Count - 2)
            {
                int lastElement = myList[i];
                myList.Remove(lastElement);
            }
        }
        return myList;
    }
}

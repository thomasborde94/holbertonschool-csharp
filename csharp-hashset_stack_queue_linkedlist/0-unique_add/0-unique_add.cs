using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> newList = new List<int>();
        int sum = 0;
        foreach (int number in myList)
        {
            if (newList.Contains(number) == false)
                newList.Add(number);
        }
        for (int i = 0; i < newList.Count; i++)
            sum += newList[i];
        return sum;
    }
}
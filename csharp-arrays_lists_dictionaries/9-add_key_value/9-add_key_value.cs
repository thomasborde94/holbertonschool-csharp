using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        foreach (string entry in myDict.Keys)
        {
            if (key == entry)
                return myDict;
        }
        myDict.Add(key, value);
        return myDict;
    }
}

# C# - Data Structures: Arrays, Lists, Dictionaries

### Task 0
To create an array of ints : `int[] newArray = new int[size];`.

### Task 1
To retrieve an element of an array : `array[index]`.

### Task 2
To replace an element in an array : `array[index] = n;`.

### Task 3
There is a difference between a null array and an array that is empty.<br>
`int[] array2 = null;` is null. Whereas `int[] array3 = {};` simply has a length of 0.<br>
In both cases, and for any arrays, you can't change its size after initialization.

### Task 4
To create a list of ints : `List<int> list = new List<int>();`. <br>
To add an element in a list, use `list.Add();`.

### Task 7
To remove an element by index, use : `list.RemoveAt(index)`.<br>
To remove an element by value, use : `list.Remove(value)`.

### Task 8
To create a Dictionary of strings : `Dictionary<string, string> openWith = new Dictionary<string, string>();`. <br>
When you use foreach to enumerate dictionary elements, the elements are retrieved as KeyValuePair objects:
```
foreach( KeyValuePair<string, string> kvp in openWith )
{
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}
// Output :
Key = txt, Value = notepad.exe
Key = bmp, Value = paint.exe
```
To get the values alone, use the Values property.
```
Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
```
To get the keys alone, use the Keys property.
```
Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;
```

### Task 9
To add a Key in a dictionary, use `dictionary.Add(key, value)`.<br>
To check if a key already exists in a dictionary, use `myDict.ContainsKey(key)`.

### Task 10
To remove a key in a dictionary, use `myDict.Remove(key);`.

### Task 11
You can't change a value inside of a foreach loop, as the value variable in the loop is a copy of the actual value in the dictionary. So this wouldn't work:
```
foreach (int value in myDict.Values)
        {
            value = value * 2;
        }
        return myDict;
```
This is because the foreach loop uses an enumerator to iterate over the collection, and this enumerator doesn't allow you to modify the collection while iterating.<br>
But you can add or remove key-value pairs during the foreach loop, as long as you do it through a separate collection or by creating a new dictionary.

# C# - Data Structures: HashSet, Stack, Queue, LinkedList

### Task 0
To determine whether an elements is in a list, use `list.Contains()`.

### Task 1
To sort a list, use `list.Sort()`.

### Task 3
To create a Stack, use `Stack<string> aStack = new Stack<string>();`.<br>
To count the items of a stack, use `aStack.Count`.<br>
To get the top item of a stack, use `var topItem = aStack.Peek()`.<br>
To remove the top item of a stack, use `aStack.Pop()`.<br>
To add a new item at the top of a stack, use `aStack.Push()`.

### Task 4
To create a Queue, use `Queue<string> aQueue = new Queue<string>();`.<br>
To count the items of a queue, use `aQueue.Count`.<br>
To get the top item of a queue, use `var topItem = aQueue.Peek()`.<br>
To remove the top item of a queue, use `aStack.Dequeue()`.<br>
To add a new item at the top of a queue, use `aStack.Enqueue()`.

### Task 5
To create a LinkedList, use `LinkedList<string> myList = new LinkedList<string>();`.<br>
To add an item to the beginning of the linked list, use `myList.AddFirst(item)`.<br>
To add an item to the end of the linked list, use `myList.AddLast(item)`.<br>
To move the first node to be the last node:
```
LinkedListNode<string> mark1 = sentence.First;
sentence.RemoveFirst();
sentence.AddLast(mark1);
```

### Task 6
To create a Node, use `LinkedListNode<String> lln = new LinkedListNode<String>( "orange" );`.<br>
To get the first node of a linkedList, use `LinkedListNode<int> current = myLList.First;`.<br>
To go to the next node, use `current.Next`. To go to the previous node, use `current.Previous`.<br>
To get the value contained in the node, use `current.Value`. To get a reference to the value held by the node, use `current.ValueRef`.
using System;

/// <summary>Generic class</summary>
class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    /// <summary>Return type of the Queue class</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Adds a node at the end of the queue
    /// </summary>
    /// <param name="value">value of the node to add</param>
    public void Enqueue(T value)
    {
        Node new_Node = new Node(value);

        if (head == null)
        {
            head = tail = new_Node;
        }
        else
        {
            tail.next = new_Node;
            tail = new_Node;
        }
        count += 1;
    }

    ///<summary>Removes the first node in the queue and returns the value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            tail.value = head.value;
            head = head.next;
            count -= 1;
            return tail.value;
        }
    }

    ///<summary>Returns the value of the first node in the queue without removing it</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    ///<summary>Prints the queue starting from the head</summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            tail = head;
            while (tail != null)
            {
                Console.WriteLine(tail.value);
                tail = tail.next;
            }
        }
    }

    /// <summary>
    /// that concatenates all values in the queue only if the queue is of type String or Char
    /// </summary>
    /// <returns>concatenated string</returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }
        else
        {
            bool isFirstWord = true;
            string concatenation = "";

            tail = head;
            if (typeof(T) == typeof(char))
            {
                while (tail != null)
                {
                    concatenation += tail.value;
                    tail = tail.next;
                }
            }
            else if (typeof(T) == typeof(string))
            {
                while (tail != null)
                {
                    if (!isFirstWord)
                    {
                        concatenation += " ";
                    }
                    
                    concatenation += tail.value;
                    tail = tail.next;
                    isFirstWord = false;
                }
            }
            return concatenation;
        }
    }
    /// <summary>Returns number of nodes in the queue</summary>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Defines Node class
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;
        public Node(T value)
        {
            this.value = value;
        }
    }
}



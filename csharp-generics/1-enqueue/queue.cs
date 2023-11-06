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
        private T value = default(T);
        public Node next = null;
        public Node(T value)
        {
            this.value = value;
        }
    }
}


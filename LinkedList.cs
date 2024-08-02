using System;

// curcilar double linked list, with it's head having null value 
public partial class LinkedList
{
    public Node head;

    public LinkedList() { 
        head = new Node();
        head.Prev = head;
        head.Next = head;
    }

    public void addElement(int value)
    {
        Node current = new Node(value);

        current.Prev = head;
        current.Next = head.Next;
        head.Next.Prev = current;
        head.Next = current;

    }
    public void printList()
    {
        Node cur = head.Next;
        while(cur != head)
        {
            Console.WriteLine(cur.Value);
            cur = cur.Next;

        }
    }
    public void removeElement(Node node) // assuming this node is in the list!!
    {
        if (node == null) return;
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
       
    }
    public void removeNumberOfElem(int value)
    {
        for (int i = 0; i < value; i++)
        {
            removeElement(head.Next);
        }
    }

}




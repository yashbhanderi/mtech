using System.Collections.Generic;
namespace Rider.C_.Collections;

public class LinkedLists
{
    public static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();
        LinkedListNode<int> node = new LinkedListNode<int>(50);

        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        list.AddLast(40);       // Add back side, at last

        list.AddFirst(100);     // Add front side, at first

        list.AddBefore(node, 200);  // Add a node at specific position
        list.AddAfter(node, 200);  // Add a node at specific position
        
        
        // 👉👉👉 Linked List Node = Similar to node created using class in c++
        LinkedListNode<int> node1 = new LinkedListNode<int>(50);
        
        list.AddLast(node1);
    
        
        
        // Console.WriteLine(node.List);       // Return Linked List contains this node
        // Console.WriteLine(node.Previous);   // Return Previous Node
        // Console.WriteLine(node.Next);   // Return Next Node

        // Console.WriteLine(node.Previous.Value);     // Return prev node value
        //
        // Console.WriteLine(node.Value);      // Return Value
        // Console.WriteLine(node.ValueRef);   // Return Value
        
        // 👉 Traversal
        
        // foreach (var item in node.List)
        // {
        //     Console.WriteLine(item);
        // }
    }
}
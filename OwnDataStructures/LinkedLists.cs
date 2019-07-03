using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnDataStructures
{

    // Representation of a node
    public class Node<T>
    {
        public T data;
        public Node<T> next;
    };

    public class LinkedLists<T>
    {
        // Function to insert node
        public Node<T> insert(Node<T> root, T item)
        {
            Node<T> temp = new Node<T>();
            Node<T> ptr;
            temp.data = item;
            temp.next = null;

            if (root == null)
                root = temp;
            else
            {
                ptr = root;
                while (ptr.next != null)
                    ptr = ptr.next;
                ptr.next = temp;
            }
            return root;
        }

        public void display(Node<T> root)
        {
            while (root != null)
            {
                Console.Write(root.data + "");
                root = root.next;
            }
        }

        public Node<T> arrayToList(T[] arr, int n)
        {
            Node<T> root = null;
            for (int i = 0; i < n; i++) root = insert(root, arr[i]); return root;
        } 
    }
}

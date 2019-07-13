using System;

namespace Stack
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }

    public class NodeStack<T>
    {
        private Node<T> head;
        private int count;

        public bool isEmpty() { return count == 0; }
        public int Count() { return count; }

        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = head;
            head = node;
            count++;
        }

        public T Pop()
        {
            if(isEmpty())
                throw new InvalidOperationException("Stack is empty!");

            Node<T> result = head;
            head = head.Next;
            count--;
            return result.Data;
        }

        public T Peek()
        {
            if (isEmpty())
                throw new InvalidOperationException("Stack is empty!");
            return head.Data;
        }

        public void Display()
        {
            Node<T> current = head;

            while (current!=null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NodeStack<string> stack = new NodeStack<string>();

            #region Push

            Console.WriteLine("Push");

            stack.Push("Bob");
            stack.Push("Alice");
            stack.Push("Tom");

            stack.Display();

            #endregion

            #region Pop

            Console.WriteLine("Pop");
            Console.WriteLine(stack.Pop());
            Console.WriteLine();

            #endregion

            #region Peek

            Console.WriteLine("Peek");
            Console.WriteLine(stack.Peek());
            Console.WriteLine();

            #endregion

            Console.ReadKey();

        }
    }
}

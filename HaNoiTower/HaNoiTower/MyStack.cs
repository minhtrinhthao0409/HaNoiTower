namespace HaNoiTowerGame
{
    public class MyStack<T>
    {
        private Node<T> top;
        private int count = 0;

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T> { data = data, next = top };
            top = newNode;
            count++;
        }

        public T Pop()
        {
            if (IsEmpty()) return default;
            T data = top.data;
            top = top.next;
            count--;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty()) return default;
            return top.data;
        }

        public int Count()
        {
            return count;
        } 

        public T[] ToArray()
        {
            T[] arr = new T[count];
            Node<T> current = top;
            int i = 0;
            while (current != null)
            {
                arr[i++] = current.data;
                current = current.next;
            }
            return arr;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }
    }

}


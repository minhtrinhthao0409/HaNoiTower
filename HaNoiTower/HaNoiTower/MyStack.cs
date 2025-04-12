namespace HaNoiTowerGame
{
    public class MyStack
    {
        Node top;
        private int count = 0;

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(object data)
        {
            Node newNode = new Node { data = data, next = top };
            top = newNode;
            count++;
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                return null;
            }

            object data = top.data;
            top = top.next;
            if (count >= 0)
                count--;
            return data;
        }

        public object Peek()
        {
            if (IsEmpty()) return null;
            return top.data;
        }
        public int Count()
        {
            return count;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }

    }
}

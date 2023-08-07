namespace CodeChallenges
{
    public class StackQueuePsuedo
    {
        private Stack<int> enqueueStack = new Stack<int>();
        private Stack<int> dequeueStack = new Stack<int>();

        public void Enqueue(int item)
        {
            enqueueStack.Push(item);
        }

        public int Dequeue()
        {
            if (dequeueStack.Count == 0)
            {
                if (enqueueStack.Count == 0)
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                while (enqueueStack.Count > 0)
                {
                    dequeueStack.Push(enqueueStack.Pop());
                }
            }

            return dequeueStack.Pop();
        }
    }
}

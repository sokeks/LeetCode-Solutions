public class MyStack {
    private readonly Queue<int> queue = new Queue<int>();
    
    public void Push(int x) {
        queue.Enqueue(x);
        for (var i = 0; i < queue.Count - 1; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }
    
    public int Pop() {
        return queue.Dequeue();
    }
    
    public int Top() {
        return queue.Peek();
    }
    
    public bool Empty() {
        return queue.Count == 0;   
    }
}


public class MyStack2Queues {
    private Queue<int> active;
    private Queue<int> aux;

    private int top;

    public MyStack2Queues() {
        active = new Queue<int>();
        aux = new Queue<int>();
    }
    
    public void Push(int x) {
        active.Enqueue(x);
        top = x;
    }
    
    public int Pop() {
        if (active.Count == 1)
        {
            top = default;
            return active.Dequeue();
        }

        while(active.Count > 2)
        {
            aux.Enqueue(active.Dequeue());
        }
        top = active.Peek();
        aux.Enqueue(active.Dequeue());
        var item = active.Dequeue();

        var temp = active;
        active = aux;
        aux = temp;

        return item;
    }
    
    public int Top() {
        return top;
    }
    
    public bool Empty() {
        return active.Count == 0;   
    }

    private void MoveAllButOne()
    {
        while(active.Count > 1)
        {
            aux.Enqueue(active.Dequeue());
        }
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
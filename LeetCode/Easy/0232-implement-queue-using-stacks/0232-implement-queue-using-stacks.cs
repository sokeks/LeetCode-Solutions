public class MyQueue {
    private readonly Stack<int> s_in = new Stack<int>();
    private readonly Stack<int> s_out = new Stack<int>();
    
    public void Push(int x) {
        s_in.Push(x);
    }
    
    public int Pop() {
        EnsureOutputStackHasElements();
        return s_out.Pop();
    }

    
    public int Peek() {
        EnsureOutputStackHasElements();
        return s_out.Peek();
    }
    
    public bool Empty() {
        return s_in.Count == 0 && s_out.Count == 0;
    }

    private void EnsureOutputStackHasElements()
    {
        if (s_out.Count == 0)
        {
            while (s_in.Count > 0)
            {
                s_out.Push(s_in.Pop());
            }
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
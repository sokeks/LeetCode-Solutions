public class SmallestInfiniteSet {
    private int _setStart = 1;
    private readonly PriorityQueue<int, int> _minHeap = new(); 
    private readonly HashSet<int> _inHeap = new(); 
    
    public int PopSmallest() {
        if (_minHeap.Count > 0)
        {
            var val = _minHeap.Dequeue();
            _inHeap.Remove(val);
            return val;
        }
        
        return _setStart++; 
    }
    
    public void AddBack(int num) {
        if (num < _setStart && !_inHeap.Contains(num))
        {
            _minHeap.Enqueue(num, num);
            _inHeap.Add(num);
        }        
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
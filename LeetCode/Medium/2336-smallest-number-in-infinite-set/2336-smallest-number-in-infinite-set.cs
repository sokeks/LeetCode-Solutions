public class SmallestInfiniteSet {
    private int _setStart = 1;
    private readonly PriorityQueue<int, int> _addedElements = new(); 
    private readonly HashSet<int> _inAddedElements = new(); 
    
    public int PopSmallest() {
        if (_addedElements.Count > 0)
        {
            var val = _addedElements.Dequeue();
            _inAddedElements.Remove(val);
            return val;
        }
        
        return _setStart++; 
    }
    
    public void AddBack(int num) {
        if (num < _setStart && !_inAddedElements.Contains(num))
        {
            _addedElements.Enqueue(num, num);
            _inAddedElements.Add(num);
        }        
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
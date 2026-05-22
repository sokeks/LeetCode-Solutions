public class RecentCounter {
    private const int timeWindowSizeMs = 3000;
    private readonly Queue<int> recentPingTimes = new Queue<int>(timeWindowSizeMs + 1);
    
    public int Ping(int t) {
        recentPingTimes.Enqueue(t);
        while (recentPingTimes.Peek() < (t - timeWindowSizeMs)) recentPingTimes.Dequeue();

        return recentPingTimes.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
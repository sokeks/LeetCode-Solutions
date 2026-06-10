public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        if (costs.Length == k) return Sum(costs);
        var leftWorkers = new PriorityQueue<int, (int val, int idx)>(candidates);
        var rightWorkers = new PriorityQueue<int, (int val, int idx)>(candidates);

        var (left, right) = Populate(leftWorkers, rightWorkers, costs, candidates);
        
        var sessionCount = 0;
        var totalCost = 0L;
        for (; sessionCount < k && leftWorkers.Count > 0 && rightWorkers.Count > 0; sessionCount++)
        {
            var leftWorker = leftWorkers.Peek();
            var rightWorker = rightWorkers.Peek();

            Console.WriteLine($"{sessionCount}: {left}->{leftWorker} {right}->{rightWorker}");

            if (leftWorker <= rightWorker)
            {
                totalCost += leftWorker;
                if (left <= right) leftWorkers.DequeueEnqueue(costs[left], (costs[left], left));
                else leftWorkers.Dequeue();
                
                left++;
            }
            else
            {
                totalCost += rightWorker;
                if (left <= right) rightWorkers.DequeueEnqueue(costs[right], (costs[right], right));
                else rightWorkers.Dequeue();
                
                right--;
            }
        }

        if (sessionCount == k) return totalCost;

        var workers = leftWorkers.Count > 0 ? leftWorkers : rightWorkers;

        for (; sessionCount < k && workers.Count > 0; sessionCount++)
        {
            totalCost += workers.Dequeue();
        }

        return totalCost;

        static long Sum(int[] arr)
        {
            var sum = 0L;
            foreach (var a in arr) sum += a;
            return sum;
        }
        static (int left, int right) Populate(PriorityQueue<int, (int val, int idx)> leftWorkers,
            PriorityQueue<int, (int val, int idx)> rightWorkers, int[] costs, int candidates)
        {
            var left = 0;
            for (; left < candidates && left < costs.Length; left++)
            {
                leftWorkers.Enqueue(costs[left], (costs[left], left));
            }

            var right = costs.Length - 1;
            for (; right >= costs.Length - candidates && right >= left; right--)
            {
                rightWorkers.Enqueue(costs[right], (costs[right], right));
            }

            return (left, right);
        }
    }
}
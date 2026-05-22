public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        if (arr.Length == 1) return true;

        var numToFrequencies = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            numToFrequencies.TryGetValue(num, out int freq);
            numToFrequencies[num] = freq + 1;
        }

        var occurrences = new HashSet<int>(numToFrequencies.Count);
        foreach (var freq in numToFrequencies.Values)
        {
            if (!occurrences.Add(freq)) return false;
        }

        return true;
    }
}
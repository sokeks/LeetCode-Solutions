func minOperations(word1 string, word2 string) int {
    dp := make([]int, len(word1) + 1)

    for prefixLength := 1; prefixLength <= len(word1); prefixLength++ {
        minOperationsCount := prefixLength
        for start := 0; start < prefixLength; start++ {
            straightOperationsCount := countReplacesAndSwaps(word1, word2, start, prefixLength, false)
            reversedOperationsCount := 1 + countReplacesAndSwaps(word1, word2, start, prefixLength, true)
            minOperationsCount = min(minOperationsCount, dp[start] +  min(straightOperationsCount, reversedOperationsCount))
        }
        dp[prefixLength] = minOperationsCount 
    }

    return dp[len(dp) - 1]
}

func countReplacesAndSwaps(source, target string, start, end int, isReversed bool) int {
    charPairCounts := [26][26]int{}

    for i := start; i < end; i++ {
        s := source[i]
        
        var t byte
        if isReversed {
            t = target[start + end - 1 - i]
        } else {
            t = target[i]
        }

        if s != t {
            charPairCounts[s - 'a'][t - 'a']++
        }
    }

    replacesAndSwapsCount := 0
    for i := 0; i < 26; i++ {
        for j := i + 1; j < 26; j++ {
            replacesAndSwapsCount += max(charPairCounts[i][j], charPairCounts[j][i])
        }
    }
    
    return replacesAndSwapsCount
}
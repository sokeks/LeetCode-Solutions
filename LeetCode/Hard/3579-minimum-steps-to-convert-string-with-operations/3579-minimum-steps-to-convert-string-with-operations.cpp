class Solution {
public:
    int minOperations(string word1, string word2) {
        vector dp(word1.length() + 1, 0);

        for (auto prefixLength = 1uz; prefixLength <= word1.length(); ++prefixLength)
        {
            auto minOperationsCount = prefixLength;
            for (auto start = 0uz; start < prefixLength; ++start)
            {
                string_view source(word1.data() + start, prefixLength - start);
                string_view target(word2.data() + start, prefixLength - start);

                auto nonReversedOperations = countReplacesAndSwaps(source, target);
                auto reversedOperations = 1 + countReplacesAndSwaps(source | views::reverse, target);

                minOperationsCount = min(dp[start] + min(nonReversedOperations, reversedOperations), minOperationsCount);
            }
            dp[prefixLength] = minOperationsCount;
        }

        return dp.back();
    }
private:
    template <typename R1, typename R2>
    size_t countReplacesAndSwaps(R1&& source, R2&& target)
    {
        array<array<int, 26>, 26> pair_mismatches = {};

        for (auto [s, t] : views::zip(source, target))
        {
            if (s != t)
            {
                pair_mismatches[s - 'a'][t - 'a']++;
            }
        }

        auto operationsCount = 0uz;
        for (auto s = 0uz; s < pair_mismatches.size(); ++s)
        {
            for (auto t = s + 1; t < pair_mismatches.size(); ++t)
            {
                operationsCount += max(pair_mismatches[s][t], pair_mismatches[t][s]);
            }
        }

        return operationsCount;
    } 
};
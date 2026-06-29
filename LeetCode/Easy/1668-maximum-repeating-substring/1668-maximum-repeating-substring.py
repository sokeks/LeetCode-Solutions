class Solution:
    # DP version
    def maxRepeating(self, sequence: str, word: str) -> int:
        m, n = len(word), len(sequence)
        if m > n: return 0

        repeating_word_count = [0] * (n + 1)
        max_k = 0
        for i in range(m,  n + 1):
            if sequence.endswith(word, i - m, i):
                repeating_word_count[i] = repeating_word_count[i - m] + 1
                if repeating_word_count[i] > max_k:
                    max_k = repeating_word_count[i]

        return max_k


    # brute force based on Boyer-Moore matching algorithm, not an optimal but for constraints is enough and... it's very elegant :)
    # def maxRepeating(self, sequence: str, word: str) -> int:
    #     k = len(sequence) // len(word)

    #     while k > 0:
    #         if word * k in sequence:
    #             return k
    #         k -= 1

    #     return 0
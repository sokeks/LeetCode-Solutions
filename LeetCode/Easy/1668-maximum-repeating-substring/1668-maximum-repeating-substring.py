class Solution:
    # DP version
    def maxRepeating(self, sequence: str, word: str) -> int:
        word_len, seq_len = len(word), len(sequence)
        if word_len > seq_len: return 0

        repeating_word_count = [0] * (seq_len + 1)
        max_k = 0
        for i in range(word_len,  seq_len + 1):
            if sequence.endswith(word, i - word_len, i):
                repeating_word_count[i] = repeating_word_count[i - word_len] + 1
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
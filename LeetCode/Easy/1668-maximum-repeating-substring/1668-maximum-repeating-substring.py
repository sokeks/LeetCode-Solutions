class Solution:
    def maxRepeating(self, sequence: str, word: str) -> int:
        k = len(sequence) // len(word)

        while k > 0:
            if word * k in sequence:
                return k
            k -= 1

        return 0
        
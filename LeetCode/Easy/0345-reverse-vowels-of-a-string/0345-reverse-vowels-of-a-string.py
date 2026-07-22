class Solution:
    def reverseVowels(self, s: str) -> str:
        VOWELS = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']

        left = 0
        right = len(s) - 1
        result = list(s)

        while left < right:
            while left < right and s[left] not in VOWELS:
                left += 1
            
            while left < right and s[right] not in VOWELS:
                right -= 1
            
            if s[left] in VOWELS and s[right] in VOWELS:
                result[left], result[right] = s[right], s[left]
            
            left += 1
            right -= 1

        return "".join(result)
class Solution:
    def reverseVowels(self, s: str) -> str:
        VOWELS = set("aeiouAEIOU")

        left = 0
        right = len(s) - 1
        result = list(s)

        while left < right:
            while left < right and result[left] not in VOWELS:
                left += 1
            
            while left < right and result[right] not in VOWELS:
                right -= 1
            
            if left < right:
                result[left], result[right] = result[right], result[left]
            
            left += 1
            right -= 1

        return "".join(result)
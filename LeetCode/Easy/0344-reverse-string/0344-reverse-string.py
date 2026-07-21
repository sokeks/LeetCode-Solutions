class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        right = -1

        for i in range(len(s) // 2):
            s[i], s[right] = s[right], s[i]
            right -= 1
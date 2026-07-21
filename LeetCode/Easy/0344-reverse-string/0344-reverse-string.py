class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        # super pythonic
        s.reverse()
        return

        # algorythmic
        for i in range(len(s) // 2):
            s[i], s[~i] = s[~i], s[i]
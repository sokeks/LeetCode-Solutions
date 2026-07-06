class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        # index based to omit any additional allocation, but being much less cpu saving than below
        i = len(s) - 1

        while i >= 0 and s[i] == " ":
            i -= 1

        j = i
        while j >= 0 and s[j] != " ":
            j -= 1

        return i - j

        # using generators (quite pythonic)
        trimmed = dropwhile(lambda c: c == " ", reversed(s))
        return sum(1 for _ in takewhile(lambda c: c != " ", trimmed))

        # rstrip based to omit huge s with many words allocation issue, however we have to allocate new string after rstip(" ")
        s = s.rstrip()
        idx = s.rfind(" ")
        return len(s) - (idx + 1)
        
        # split based - pythonic, but for huge s we end up allocating big words array
        words = s.split()
        return len(words[-1])
        # return len(words[-1]) if len(words) > 0 else 0
    
    

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        # non pythonic version for lowercase English letters
        ALPHABET_SIZE = 26
        chars = [0] * ALPHABET_SIZE
        for c in s:
            chars[ord(c) - ord('a')] += 1
        
        for c in t:
            chars[ord(c) - ord('a')] -= 1

        for c in chars:
            if c != 0:
                return False
        
        return True


        # non pythonic version ready for unicode
        freqs_s = defaultdict(int)
        for c in s:
            freqs_s[c] += 1
        
        freqs_t = defaultdict(int)
        for c in t:
            freqs_t[c] += 1

        return freqs_s == freqs_t

        # quick pythonic one
        return Counter(s) == Counter(t)
        
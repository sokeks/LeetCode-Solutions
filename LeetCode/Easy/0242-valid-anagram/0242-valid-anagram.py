class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        # non pythonic version for lowercase English letters
        # ALPHABET_SIZE = 26
        # chars = [0] * ALPHABET_SIZE
        # for c in s:
        #     chars[ord(c) - ord('a')] += 1
        
        # for c in t:
        #     idx = ord(c) - ord('a')
        #     chars[idx] -= 1
        #     if chars[idx] < 0:
        #         return False

        # for c in chars:
        #     if c != 0:
        #         return False
        
        # return True

        # non pythonic version ready for unicode
        freqs = defaultdict(int)
        for c in s:
            freqs[c] += 1
        
        for c in t:
            freqs[c] -= 1
            if freqs[c] < 0:
                return False


        return all(f == 0 for f in freqs.values())

        # quick pythonic one
        return Counter(s) == Counter(t)
        
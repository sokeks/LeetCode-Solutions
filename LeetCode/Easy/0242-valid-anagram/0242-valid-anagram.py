class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        freqs_s = defaultdict(int)
        for c in s:
            freqs_s[c] += 1
        
        freqs_t = defaultdict(int)
        for c in t:
            freqs_t[c] += 1

        return freqs_s == freqs_t

        # quick pythonic one
        return Counter(s) == Counter(t)
        
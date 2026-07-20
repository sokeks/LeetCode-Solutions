class Solution:
    def wordPattern(self, pattern: str, s: str) -> bool:
        s_splitted = s.split(" ")
        if len(pattern) != len(s_splitted):
            return False

        ALPHABET_SIZE = 26
        char_to_words = [""] * ALPHABET_SIZE
        word_to_chars = {}

        for c, word in zip(pattern, s_splitted):
            if char_to_words[ord(c) - ord('a')] != "":
                if char_to_words[ord(c) - ord('a')] != word:
                    return False
            else:
                char_to_words[ord(c) - ord('a')] = word
            
            if word in word_to_chars:
                if word_to_chars[word] != c:
                    return False
            else:
                word_to_chars[word] = c
        
        return True
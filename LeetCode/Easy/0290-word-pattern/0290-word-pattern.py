class Solution:
    def wordPattern(self, pattern: str, s: str) -> bool:
        s_words = s.split(" ")
        if len(pattern) != len(s_words):
            return False

        char_to_words = {}
        seen_words = set()

        for c, word in zip(pattern, s_words):
            existing_word = char_to_words.get(c)
            if existing_word:
                if existing_word != word:
                    return False
            else:
                if word in seen_words:
                    return False
                char_to_words[c] = word
                seen_words.add(word)
        
        return True
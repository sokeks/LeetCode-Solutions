class Trie:
    class TrieNode:
        def __init__(self):
            self.children = {}
            self.is_end_of_the_word = False

    def __init__(self):
        self.root = Trie.TrieNode()

    def insert(self, word: str) -> None:
        current = self.root
        for char in word:
            if char not in current.children:
                current.children[char] = Trie.TrieNode()
            current = current.children[char]
        current.is_end_of_the_word = True
        
    def _search(self, string: str, finisher: Callable[[TrieNode], bool]):
        current = self.root
        for char in string:
            if char not in current.children:
                return False
            current = current.children[char]
        return finisher(current)

    def search(self, word: str) -> bool:
        return self._search(word, lambda node: node.is_end_of_the_word)

    def startsWith(self, prefix: str) -> bool:
        return self._search(prefix, lambda _: True)
        


# Your Trie object will be instantiated and called as such:
# obj = Trie()
# obj.insert(word)
# param_2 = obj.search(word)
# param_3 = obj.startsWith(prefix)
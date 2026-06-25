public class Trie 
{
    private static int AlphabetLettersCount = 26;
    private TrieNode root = new TrieNode();
    
    public void Insert(string word) {
        var current = root;
        foreach (var c in word)
        {
            if (current.Children == null || current.Children[c - 'a'] == null)
            {
                if (current.Children == null) current.Children = new TrieNode[AlphabetLettersCount]; 
                current.Children[c - 'a'] = new TrieNode();
            }
            current = current.Children[c - 'a'];
        }

        current.IsEndOfTheWord = true;
    }
    
    public bool Search(string word) {
        var node = GetEndNodeOf(word);
        return node != null && node.IsEndOfTheWord;
    }
    
    public bool StartsWith(string prefix) {
        return GetEndNodeOf(prefix) != null;
    }

    private TrieNode GetEndNodeOf(string str)
    {
        var current = root;
        foreach (var c in str)
        {
            if (current.Children == null || current.Children[c - 'a'] == null) return null;
            current = current.Children[c - 'a'];
        }

        return current;
    }

    class TrieNode
    {
        public bool IsEndOfTheWord = false;
        public TrieNode[] Children;
    }
}


/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
class Solution:
    _PARENTHESES = {"(" : ")", "{" : "}", "[" : "]"}
    def isValid(self, s: str) -> bool:
        opened_parentheses = []

        for c in s:
            if c in self._PARENTHESES:
                opened_parentheses.append(c)
            elif not opened_parentheses or self._PARENTHESES[opened_parentheses[-1]] != c:
                return False
            else:
                opened_parentheses.pop()
        
        return not opened_parentheses
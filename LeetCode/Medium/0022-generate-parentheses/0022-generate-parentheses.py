class Solution:
    def generateParenthesis(self, n: int) -> List[str]:
        stack: Deque[Tuple[char: str, opened: int, closed: int]]  = deque()
        stack.append(("(", 1, 0))
        parentheses_combinations = []
        combination_len = 2 * n
        combination = [" "] * combination_len

        while stack:
            parenthese, opened, closed = stack.pop()
            combination[opened + closed - 1] = parenthese
            if opened + closed == combination_len:
                parentheses_combinations.append("".join(combination))
            else:
                if opened < n:
                    stack.append(("(", opened + 1, closed))
                if closed < opened:
                    stack.append((")", opened, closed + 1))

        return parentheses_combinations
        
        
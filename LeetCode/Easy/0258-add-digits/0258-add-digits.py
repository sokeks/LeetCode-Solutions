class Solution:
    def addDigits(self, num: int) -> int:
        # version from followup - golden
        return (num - 1) % 9 + 1 if num else 0

        # version from followup - my thinking
        result = num % 9
        return result if result != 0 or num == 0 else 9 

        # standard version
        while num // 10:
            result = 0
            while num:
                num, carry = divmod(num, 10)
                result += carry
            num = result
        
        return num
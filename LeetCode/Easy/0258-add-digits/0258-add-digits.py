class Solution:
    def addDigits(self, num: int) -> int:
        result = num % 9
        return result if result != 0 or num == 0 else 9 


        while num // 10:
            result = 0
            while num:
                num, carry = divmod(num, 10)
                result += carry
            num = result
        
        return num
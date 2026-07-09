class Solution:
    def isHappy(self, n: int) -> bool:
        occurred = set()

        while n != 1:
            if n in occurred:
                return False
            
            occurred.add(n)
            
            result = 0
            while n:
                result += ((n % 10) ** 2)
                n //= 10
            
            n = result
        
        return True
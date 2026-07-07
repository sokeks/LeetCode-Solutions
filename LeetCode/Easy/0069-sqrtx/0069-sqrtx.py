class Solution:
    def mySqrt(self, x: int) -> int:
        if x == 0 or x == 1: return x
        left = 1
        right = x // 2

        while left < right:
            mid = (left + right + 1) // 2

            power_of_mid = mid * mid
            if power_of_mid == x:
                return mid
            elif power_of_mid < x:
                left = mid
            else:
                right = mid - 1
        
        return left
            
        
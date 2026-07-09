class Solution:
    def isHappy(self, n: int) -> bool:
        def generate_next_number(n: int):
            # return sum(int(x) ** 2 for x in str(n))
            result = 0
            while n:
                n, remainder = divmod(n, 10)
                result += (remainder ** 2)

            return result
                

        occurred = set()

        while n != 1:
            if n in occurred:
                return False
            
            occurred.add(n)
            n = generate_next_number(n)
            
        
        return True
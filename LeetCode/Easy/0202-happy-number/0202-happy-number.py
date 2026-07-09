class Solution:
    def isHappy(self, n: int) -> bool:
        def generate_next_number(n: int):
            # return sum(int(x) ** 2 for x in str(n))
            result = 0
            while n:
                n, remainder = divmod(n, 10)
                result += (remainder ** 2)

            return result

        # version with 2 pointers - gives only O(1) space complexity - based on linked lists loops detection

        slow = generate_next_number(n)
        fast = generate_next_number(generate_next_number(n))
        while slow != fast and fast != 1:
            slow = generate_next_number(slow)
            fast = generate_next_number(generate_next_number(fast))
            
        return fast == 1

        # version with set - adding O(N) space complexity
        occurred = set()

        while n != 1:
            if n in occurred:
                return False
            
            occurred.add(n)
            n = generate_next_number(n)
            
        return True
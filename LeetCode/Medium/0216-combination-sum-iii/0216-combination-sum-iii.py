
class Item(NamedTuple):
    number: int
    position: int
    current_sum: int

class Solution:
    def _populate_stack_with_next_numbers(self, stack : Deque[Item], current: Item, target: int):
        for i in range(current.number + 1, 10):
            new_sum = current.current_sum + i
            if new_sum > target: break
            stack.append(Item(number=i, position=current.position + 1, current_sum=new_sum))

    def combinationSum3(self, k: int, n: int) -> List[List[int]]:
        stack = deque()
        self._populate_stack_with_next_numbers(stack, Item(number=0, position=-1, current_sum=0), n)

        combinations = []
        elements = [None] * k
        while stack:
            item = stack.pop()
            elements[item.position] = item.number
            if item.position == k - 1:
                if item.current_sum == n:
                    combinations.append(elements.copy())
            else:
                self._populate_stack_with_next_numbers(stack, item, n)

        return combinations
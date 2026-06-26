
class State(NamedTuple):
    number: int
    position: int
    current_sum: int

class Solution:
    def _generate_next_states(self, current: State, target_k: int, target_sum: int):
        for i in range(current.number + 1, 10 - ((target_k - 1) - (current.position + 1))):
            new_sum = current.current_sum + i
            if new_sum > target_sum: break
            yield State(number=i, position=current.position + 1, current_sum=new_sum)

    def combinationSum3(self, k: int, n: int) -> List[List[int]]:
        stack = deque()
        stack.extend(self._generate_next_states(State(number=0, position=-1, current_sum=0), k, n))

        combinations = []
        elements = [None] * k
        while stack:
            state = stack.pop()
            elements[state.position] = state.number
            if state.position == k - 1:
                if state.current_sum == n:
                    combinations.append(elements.copy())
                continue
            stack.extend(self._generate_next_states(state, k, n))

        return combinations
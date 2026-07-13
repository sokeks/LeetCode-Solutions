class MyQueue:

    def __init__(self):
        self.inbound = []
        self.outbound = []
        self.first_x = None

    def push(self, x: int) -> None:
        if not self.inbound and not self.outbound:
            self.first_x = x

        while self.outbound:
            self.inbound.append(self.outbound.pop())

        self.inbound.append(x)

    def pop(self) -> int:
        while len(self.inbound) > 1:
            self.outbound.append(self.inbound.pop())     

        x = self.inbound.pop() if self.inbound else self.outbound.pop()
        self.first_x = self.outbound[-1] if self.outbound else None
        return x

    def peek(self) -> int:
        return self.first_x

    def empty(self) -> bool:
        return not self.inbound and not self.outbound


# Your MyQueue object will be instantiated and called as such:
# obj = MyQueue()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.peek()
# param_4 = obj.empty()
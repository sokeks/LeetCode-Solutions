class MyQueue:

    def __init__(self):
        self.inbound = []
        self.outbound = []

    def _pour_into_outboud(self) -> None:
        while self.inbound:
            self.outbound.append(self.inbound.pop())

    def push(self, x: int) -> None:
        self.inbound.append(x)

    def pop(self) -> int:
        if not self.outbound:
            self._pour_into_outboud()

        return self.outbound.pop()

    def peek(self) -> int:
        if not self.outbound:
            self._pour_into_outboud()
        return self.outbound[-1]

    def empty(self) -> bool:
        return not self.inbound and not self.outbound


# Your MyQueue object will be instantiated and called as such:
# obj = MyQueue()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.peek()
# param_4 = obj.empty()
# class MyStack:

#     def __init__(self):
#         self.left = Deque()
#         self.right = Deque()
#         self.top_x = None

#     def push(self, x: int) -> None:
#         self.top_x = x
#         if self.left:
#             self.left.append(x)
#         else:
#             self.right.append(x)

#     def pop(self) -> int:
#         outbound, inbound = (self.left, self.right) if self.left else (self.right, self.left)
#         for _ in range(len(outbound) - 2):
#             inbound.append(outbound.popleft())

#         if len(outbound) == 2:
#             self.top_x = outbound.popleft()
#             inbound.append(self.top_x)
#         else:
#             self.top_x = None
        
#         return outbound.popleft()

#     def top(self) -> int:
#         return self.top_x
        

#     def empty(self) -> bool:
#         return not self.left and not self.right


class MyStack:

    def __init__(self):
        self.left = Deque()
        self.right = Deque()
        self.top_x = None

    def push(self, x: int) -> None:
        self.top_x = x
        if self.left:
            self.left.append(x)
        else:
            self.right.append(x)

    def pop(self) -> int:
        outbound, inbound = (self.left, self.right) if self.left else (self.right, self.left)
        self.top_x = None
        while len(outbound) > 1:
            self.top_x = outbound.popleft()
            inbound.append(self.top_x)

        return outbound.popleft()

    def top(self) -> int:
        return self.top_x
        

    def empty(self) -> bool:
        return not self.left and not self.right


# Your MyStack object will be instantiated and called as such:
# obj = MyStack()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.top()
# param_4 = obj.empty()
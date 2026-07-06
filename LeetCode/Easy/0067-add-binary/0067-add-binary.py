class Solution:
    def addBinary(self, a: str, b: str) -> str:
        a_len = len(a)
        b_len = len(b)

        carry = 0
        shorter_len, longer_len, longer = (a_len, b_len, b) if a_len < b_len else (b_len, a_len, a)
        binary_sum = [0] * longer_len

        for i in range(shorter_len):
            bit_sum_result = int(a[a_len - 1 - i]) + int(b[b_len - 1 - i]) + carry
            carry, reminder = divmod(bit_sum_result, 2)
            
            binary_sum[longer_len - 1 - i] = reminder
        
        print(binary_sum)

        i += 1
        while carry == 1 and i < longer_len:
            bit_sum_result = int(longer[longer_len - 1 - i]) + carry
            carry, reminder = divmod(bit_sum_result, 2)
            binary_sum[longer_len - 1 - i] = reminder
            i += 1

        print(binary_sum)
        
        
        binary_sum[:(longer_len - i)] = [int(x) for x in longer[:(longer_len - i)]]

        print(binary_sum)


        return "".join(str(x) for x in (binary_sum if carry == 0 else [1] + binary_sum))
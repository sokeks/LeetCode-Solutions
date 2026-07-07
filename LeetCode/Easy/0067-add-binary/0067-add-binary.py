class Solution:
    def addBinary(self, a: str, b: str) -> str:
        # less pythonic, but more efficient
        carry = 0
        binary_sum = []

        for (a_bit, b_bit) in zip(reversed(a), reversed(b)):
            carry, result = divmod(int(a_bit) + int(b_bit) + carry, 2)
            binary_sum.append(str(result))

        longer, shorter_len = (a, len(b)) if len(a) > len(b) else (b, len(a))
        reminding_longer_bits = islice(reversed(longer), shorter_len, None)

        if carry == 1:
            for l_bit in reminding_longer_bits:
                carry, result = divmod(int(l_bit) + carry, 2)
                binary_sum.append(str(result))

                if carry == 0:
                    break
        
        if carry == 1:
            binary_sum.append('1')
        else:
            binary_sum.extend(reminding_longer_bits)
        
        return "".join(reversed(binary_sum))



        # very pythonic, but with little micro-inefficiencies for the readability purposes (if a & b differ much in length, there will be unnecessary run of code)
        carry = 0
        binary_sum = []
        for (a_bit, b_bit) in itertools.zip_longest(reversed(a), reversed(b), fillvalue='0'):
            carry, result = divmod(int(a_bit) + int(b_bit) + carry, 2)
            binary_sum.append(str(result))

        if carry == 1:
            binary_sum.append('1')
        
        return "".join(reversed(binary_sum))

        # heavily optimized version python built-in function provides. [:2] eliminates "0b" prefix
        return bin(int(a, 2) + int(b, 2))[2:]
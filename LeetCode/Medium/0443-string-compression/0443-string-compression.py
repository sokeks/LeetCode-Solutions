class Solution:
    def compress(self, chars: List[str]) -> int:          
        read_idx = 0
        write_idx = 0
        while read_idx < len(chars):
            anchor = read_idx
            while read_idx < len(chars) and chars[read_idx] == chars[anchor]:
                read_idx += 1
            
            chars[write_idx] = chars[anchor]
            write_idx += 1
            if read_idx - anchor > 1:
                count = str(read_idx - anchor)

                for c in count:
                    chars[write_idx] = c
                    write_idx += 1

        return write_idx
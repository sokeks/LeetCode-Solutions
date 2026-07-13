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
            group_length = read_idx - anchor
            if group_length > 1:
                count = str(group_length)

                for c in count:
                    chars[write_idx] = c
                    write_idx += 1

        return write_idx
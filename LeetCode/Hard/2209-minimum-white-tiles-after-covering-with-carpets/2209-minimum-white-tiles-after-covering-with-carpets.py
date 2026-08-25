class Solution:
    def minimumWhiteTiles(self, floor: str, numCarpets: int, carpetLen: int) -> int:
    
    #dp optimized for memory
        floor_ints = [int(tile) for tile in floor]
        # dp answers: how many white carpets (represented as '1') are visible for floor length under index (i-th) for that many carpets (calculate from 1 to numCarpets step by step)
        dp_previous = list(accumulate(floor_ints, initial=0))
        dp_current = [0] * len(dp_previous)
        
        for carpets in range(1, numCarpets + 1):
            for i in range(carpets * carpetLen, len(dp_previous)):
                dp_current[i] = min(dp_current[i - 1] + floor_ints[i - 1], dp_previous[i - carpetLen])
            dp_previous, dp_current = dp_current, [0] * len(dp_previous)

        return dp_previous[-1]
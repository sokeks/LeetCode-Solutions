class Solution:
    def minimumWhiteTiles(self, floor: str, numCarpets: int, carpetLen: int) -> int:
        floor_ints = [1 if tile == '1' else 0 for tile in floor]
        dp_previous = list(accumulate(floor_ints, lambda white_tiles_sum, tile : white_tiles_sum + tile, initial=0,))
        dp_current = [0] * len(dp_previous)
        
        for c in range(1, numCarpets + 1):
            for i in range(c * carpetLen, len(dp_previous)):
                dp_current[i] = min(dp_current[i - 1] + floor_ints[i - 1], dp_previous[max(0, i - carpetLen)])
            dp_previous, dp_current = dp_current, [0] * len(dp_previous)

        return dp_previous[-1]        
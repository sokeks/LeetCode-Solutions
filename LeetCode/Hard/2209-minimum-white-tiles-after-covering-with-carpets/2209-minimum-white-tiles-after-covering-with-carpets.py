class Solution:
    def minimumWhiteTiles(self, floor: str, numCarpets: int, carpetLen: int) -> int:
        def tile_value(tile: str) -> int:
            return 1 if tile == '1' else 0
        dp_previous = list(accumulate(floor, lambda white_tiles_sum, tile : white_tiles_sum + tile_value(tile), initial=0,))
        dp_current = [0] * len(dp_previous)
        
        for c in range(1, numCarpets + 1):
            for i in range(1, len(dp_previous)):
                dp_current[i] = min(dp_current[i - 1] + tile_value(floor[i - 1]), dp_previous[max(0, i - carpetLen)])
            dp_previous, dp_current = dp_current, [0] * len(dp_previous)

        return dp_previous[-1]        
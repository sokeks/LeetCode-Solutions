class Solution:
    def minMoves(self, classroom: List[str], energy: int) -> int:
        def analyze_classroom() -> tuple[all_litter_mask: int, start: tuple[int, int], litter_idxs: dict[int, dict[int, int]]]:
            litter_count = 0
            litter_idxs: dict[tuple[int, int], int] = {}
            start = (0, 0)
            for i, row in enumerate(classroom):
                for j, cell in enumerate(row):
                    if cell == 'L':
                        litter_idxs[i, j] = litter_count
                        litter_count += 1
                    elif cell == 'S':
                        start = i, j

            return (1 << litter_count) - 1, start, litter_idxs
        
        def is_move_allowed(row: int, col: int) -> bool:
            return 0 <= row < len(classroom) and 0 <= col < len(classroom[0]) and classroom[row][col] != 'X'

        all_litter_mask, (s_row, s_col), litter_idxs = analyze_classroom()
        current_highest_energy: list[list[list[int]]] = [[[-1 for _ in row] for row in classroom] for i in range(all_litter_mask + 1)]        

        queue: Deque[tuple[row: int, col: int, litter_mask: int, energy_remaining: int]] = deque()
        current_highest_energy[0][s_row][s_col] = energy
        queue.append((s_row, s_col, 0, energy))

        steps = 0
        while queue:
            queue_len = len(queue)
            for _ in range(queue_len):
                row, col, litter_mask, energy_remaining = queue.popleft()

                if litter_mask == all_litter_mask:
                    return steps

                if energy_remaining == 0:
                    continue

                for row_change, col_change in [(0, -1), (0, 1), (-1, 0), (1, 0)]:
                    next_row, next_col = row + row_change, col + col_change
                    if  not is_move_allowed(next_row, next_col):
                        continue
                
                    next_litter_mask = litter_mask | (1 << (litter_idxs[next_row, next_col]) if classroom[next_row][next_col] == 'L' else 0)
                    next_energy = energy if classroom[next_row][next_col] == 'R' else energy_remaining - 1

                    if next_energy > current_highest_energy[next_litter_mask][next_row][next_col]:
                        current_highest_energy[next_litter_mask][next_row][next_col] = next_energy
                        queue.append((next_row, next_col, next_litter_mask, next_energy))                        

            steps += 1

        return -1
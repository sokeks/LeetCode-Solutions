class Solution:
    def minMoves(self, classroom: List[str], energy: int) -> int:
        def analyze_classroom() -> tuple[all_litter_mask: int, start: tuple[int, int], litter_pos_to_idx: dict[tuple[int, int], int]]:
            litter_count = 0
            litter_pos_to_idx: dict[tuple[int, int], int] = {}
            start = (0, 0)
            for i, row in enumerate(classroom):
                for j, cell in enumerate(row):
                    if cell == 'L':
                        litter_pos_to_idx[i, j] = litter_count
                        litter_count += 1
                    elif cell == 'S':
                        start = i, j

            return (1 << litter_count) - 1, start, litter_pos_to_idx
        
        def calculate_next_moves(row: int, col: int) -> list[tuple[int, int]]:
            def is_move_allowed(row: int, col: int) -> bool:
                return 0 <= row < len(classroom) and 0 <= col < len(classroom[0]) and classroom[row][col] != 'X'
            moves = []
            if is_move_allowed(row, col - 1):
                moves.append((row, col - 1))
            if is_move_allowed(row - 1, col):
                moves.append((row - 1, col))
            if is_move_allowed(row, col + 1):
                moves.append((row, col + 1))
            if is_move_allowed(row + 1, col):
                moves.append((row + 1, col))
            return moves


        all_litter_mask, (s_row, s_col), litter_pos_to_idx = analyze_classroom()
        highest_energy_seen: list[list[list[int]]] = [[[-1 for _ in row] for row in classroom] for _ in range(all_litter_mask + 1)]        

        queue: Deque[tuple[row: int, col: int, litter_mask: int, energy_remaining: int]] = deque()
        highest_energy_seen[0][s_row][s_col] = energy
        queue.append((s_row, s_col, 0, energy))

        next_moves = [(0, -1), (0, 1), (-1, 0), (1, 0)]
        steps = 0
        while queue:
            level_size = len(queue)
            for _ in range(level_size):
                row, col, litter_mask, energy_remaining = queue.popleft()

                if litter_mask == all_litter_mask:
                    return steps

                if energy_remaining == 0:
                    continue

                for next_row, next_col in calculate_next_moves(row, col):
                    next_cell = classroom[next_row][next_col]
                    next_litter_mask = litter_mask | (1 << (litter_pos_to_idx[next_row, next_col]) if next_cell == 'L' else 0)
                    next_energy = energy if next_cell == 'R' else energy_remaining - 1

                    if next_energy > highest_energy_seen[next_litter_mask][next_row][next_col]:
                        highest_energy_seen[next_litter_mask][next_row][next_col] = next_energy
                        queue.append((next_row, next_col, next_litter_mask, next_energy))                        

            steps += 1

        return -1
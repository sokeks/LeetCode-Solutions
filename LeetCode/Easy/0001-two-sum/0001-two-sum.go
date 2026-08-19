func twoSum(nums []int, target int) []int {
    seen := make(map[int]int)

    for idx, n := range nums {
        if s_idx, ok := seen[target - n]; ok {
            return []int{idx, s_idx}
        } else {
            seen[n] = idx
        }
    }
    panic("Unreachable code")
}
func countQuadruplets(nums []int) int {
    distinctQuadrupletsCount := 0
    sumsCount := make(map[int]int)
    for c := 2; c < len(nums); c++ {
        b := c - 1
        for a := 0; a < b; a++ {
            sumsCount[nums[a] + nums[b]] += 1
        }

        for d := c + 1; d < len(nums); d++ {
            fittingSum := nums[d] - nums[c]
            distinctQuadrupletsCount += sumsCount[fittingSum]
        }
    }

    return distinctQuadrupletsCount
}
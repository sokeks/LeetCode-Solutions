func countQuadruplets(nums []int) int {
    distinctQuadrupletsCount := 0
    var sumsCount [201]int
    for c := 2; c < len(nums); c++ {
        b := c - 1
        for a := 0; a < b; a++ {
            sumsCount[nums[a] + nums[b]] += 1
        }

        for d := c + 1; d < len(nums); d++ {
            fittingSum := nums[d] - nums[c]
            if fittingSum < 2 {
                continue
            }
            distinctQuadrupletsCount += sumsCount[fittingSum]
        }
    }

    return distinctQuadrupletsCount
}
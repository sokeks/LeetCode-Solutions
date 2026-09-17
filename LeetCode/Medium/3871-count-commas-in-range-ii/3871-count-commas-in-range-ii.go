func countCommas(n int64) int64 {
    commas_count := int64(0)
    threshold := int64(1000)

    for n >= threshold {
        commas_count += n - threshold + 1
        threshold *= 1000
    }

    return commas_count
}
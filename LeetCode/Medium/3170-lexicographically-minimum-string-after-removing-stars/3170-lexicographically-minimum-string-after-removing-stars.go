type MinHeap []byte

// Implement sort.Interface
func (h MinHeap) Len() int              { return len(h) }
func (h MinHeap) Less(i, j int) bool    { return h[i] < h[j] }
func (h MinHeap) Swap(i, j int)         { h[i], h[j] = h[j], h[i] }

// Implement heap.Interface
func (h *MinHeap) Push(x any)   { *h = append(*h, x.(byte)) }

func (h *MinHeap) Pop() any {
    old := *h
    n := len(old)
    x := old[n-1]
    *h = old[:n-1]
    return x
}


type Stack []int

func (s *Stack) Push(val int) { *s = append(*s, val) }
func (s *Stack) Pop() int {
    n := len(*s)
    val := (*s)[n-1]
    *s = (*s)[:n-1]
    return val
}
func (s Stack) Len() int { return len(s) }



func clearStars(s string) string {
    availableCharsHeap := MinHeap{}
    charPositions := [26]Stack{}

    result := []byte(s)
    for i := 0; i < len(s); i++ {
        if s[i] != '*' {
            idx := s[i] - 'a'
            if len(charPositions[idx]) == 0 {
                heap.Push(&availableCharsHeap, s[i])
            }
            charPositions[idx].Push(i)
        } else {
            letter := availableCharsHeap[0]
            idx := letter - 'a'
            result[charPositions[idx].Pop()] = '*'
            if charPositions[idx].Len() == 0 {
                heap.Pop(&availableCharsHeap)
            }
        }
    }

    n := 0
    for _, letter := range result {
        if letter != '*' {
            result[n] = letter
            n++
        }
    }
    
    return string(result[:n])
}
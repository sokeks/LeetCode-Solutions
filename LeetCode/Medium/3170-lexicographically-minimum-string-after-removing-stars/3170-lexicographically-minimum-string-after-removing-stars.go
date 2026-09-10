type MinHeap []byte

// Implemente sort.Interface
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



func clearStars(s string) string {
    available_chars_heap := MinHeap{}
    char_positions := [26]Stack{}

    result := []byte(s)
    for i := 0; i < len(s); i++ {
        if s[i] != '*' {
            idx := s[i] - 'a'
            if len(char_positions[idx]) == 0 {
                heap.Push(&available_chars_heap, s[i])
            }
            char_positions[idx].Push(i)
        } else {
            char := available_chars_heap[0]
            idx := char - 'a'
            result[char_positions[idx].Pop()] = '*'
            if len(char_positions[idx]) == 0 {
                heap.Pop(&available_chars_heap)
            }
        }
    }

    n := 0
    for _, char := range result {
        if char != '*' {
            result[n] = char
            n++
        }
    }
    
    return string(result[:n]);
}
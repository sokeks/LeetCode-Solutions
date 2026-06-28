# LeetCode-Solutions

This repository keeps all my coded solutions to the tasks from LeetCode webpage. Most (if not all) tasks were moved from LH page to GH via [LeetHub-3.0](https://chromewebstore.google.com/detail/kdkgpjpenaeoodajljkflmlnkoihkmda?utm_source=item-share-cb), which I highly recommend. That also explains why most of the commits are having very close datetimes.

## Approach to solving the tasks

I follow below algorithm:
1. Read a task and think about the approach (so the concept how to solve it) and solution (so the code how to write it).
2. If I am not able to find an approach and 15-20 minutes have passed, I am asking any AI for help:

> LeetCode Task:
>
> Where did I stuck/what I have tried:
>
> Instruction: Trigger **[Socratic Hinting]**. Under no circumstances should you write me ready-to-use code or the full algorithm. Ask 1-2 guiding questions that will point me toward the right pattern or data structure that I am missing. Give me a chance to have an "Aha!" moment.

3. If I am not sure about the approach I verify it with any AI using this prompt:

>  LeetCode Task:
> 
>  My concept: Describe it here
> 
>  Expected complexity: Time O(N), Space O(N)
> 
>  Instruction: Trigger **[Edge-Case Injector]**. Give me 2-3 pathological edge cases or malicious inputs that could destroy this approach. Do not provide code or ready-made solutions; just throw hard test cases at me to think about.

3. If I am sure about the approach, then I write the code and verify it with any AI using this prompt:

> LeetCode Task:
>
> Source Code:
>
> Instruction: Trigger **[L6 Rubric Grading]** and **[Socratic Review]**. Evaluate the code quality as if this were a production code review at FAANG (readability, variable naming, early returns, modularity, and task-specific aspects) for code written using Design by Contract (not defensively) by an L6 engineer.
> Bug Handling: If there are bugs (logical or performance), ask me pointed questions targeting the gaps so I can find the bug myself. Do not give me the corrected code.
>
> Constraints: Keep LeetCode's sandbox limitations in mind; for example, for security reasons, System.Runtime.InteropServices is blocked (meaning you cannot use ref returns for dictionary values), and ArrayPool.Shared.Rent is unavailable. We do not initialize the data structures with the max input from task decription.

4. If I have successfully resolved all the comments and discussions with AI I move to System Design question:

> Instruction: Trigger **[Constraint Escalation]**. Drastically change the hardware or business constraints of this problem (this may include, but is not limited to: an infinite data stream instead of an in-memory array, data that doesn't fit in RAM, an O(1) space requirement, a distributed environment, etc.).
> 
> Actionable Output: Ask me exactly one architectural question about how I would adapt my approach to these new realities.


## Last word

Have fun exploring! Always happy to discuss certain resolutions I've decided to make.

<!---LeetCode Topics Start-->
# LeetCode Topics
## Tree
| Problem Name | Difficulty |
| ------- | ------- |
| [0199-binary-tree-right-side-view](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0199-binary-tree-right-side-view/) | Medium |
| [0226-invert-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0226-invert-binary-tree/) | Easy |
| [0236-lowest-common-ancestor-of-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0236-lowest-common-ancestor-of-a-binary-tree/) | Medium |
| [0257-binary-tree-paths](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0257-binary-tree-paths/) | Easy |
| [0404-sum-of-left-leaves](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0404-sum-of-left-leaves/) | Easy |
| [0450-delete-node-in-a-bst](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0450-delete-node-in-a-bst/) | Medium |
| [0700-search-in-a-binary-search-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0700-search-in-a-binary-search-tree/) | Easy |
| [1161-maximum-level-sum-of-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1161-maximum-level-sum-of-a-binary-tree/) | Medium |
| [1372-longest-zigzag-path-in-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1372-longest-zigzag-path-in-a-binary-tree/) | Medium |
## Depth-First Search
| Problem Name | Difficulty |
| ------- | ------- |
| [0199-binary-tree-right-side-view](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0199-binary-tree-right-side-view/) | Medium |
| [0226-invert-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0226-invert-binary-tree/) | Easy |
| [0236-lowest-common-ancestor-of-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0236-lowest-common-ancestor-of-a-binary-tree/) | Medium |
| [0257-binary-tree-paths](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0257-binary-tree-paths/) | Easy |
| [0399-evaluate-division](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0399-evaluate-division/) | Medium |
| [0404-sum-of-left-leaves](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0404-sum-of-left-leaves/) | Easy |
| [0547-number-of-provinces](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0547-number-of-provinces/) | Medium |
| [0841-keys-and-rooms](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0841-keys-and-rooms/) | Medium |
| [1161-maximum-level-sum-of-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1161-maximum-level-sum-of-a-binary-tree/) | Medium |
| [1372-longest-zigzag-path-in-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1372-longest-zigzag-path-in-a-binary-tree/) | Medium |
| [1466-reorder-routes-to-make-all-paths-lead-to-the-city-zero](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1466-reorder-routes-to-make-all-paths-lead-to-the-city-zero/) | Medium |
## Breadth-First Search
| Problem Name | Difficulty |
| ------- | ------- |
| [0199-binary-tree-right-side-view](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0199-binary-tree-right-side-view/) | Medium |
| [0226-invert-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0226-invert-binary-tree/) | Easy |
| [0399-evaluate-division](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0399-evaluate-division/) | Medium |
| [0404-sum-of-left-leaves](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0404-sum-of-left-leaves/) | Easy |
| [0547-number-of-provinces](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0547-number-of-provinces/) | Medium |
| [0841-keys-and-rooms](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0841-keys-and-rooms/) | Medium |
| [0994-rotting-oranges](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0994-rotting-oranges/) | Medium |
| [1161-maximum-level-sum-of-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1161-maximum-level-sum-of-a-binary-tree/) | Medium |
| [1466-reorder-routes-to-make-all-paths-lead-to-the-city-zero](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1466-reorder-routes-to-make-all-paths-lead-to-the-city-zero/) | Medium |
| [1926-nearest-exit-from-entrance-in-maze](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1926-nearest-exit-from-entrance-in-maze/) | Medium |
## Binary Tree
| Problem Name | Difficulty |
| ------- | ------- |
| [0199-binary-tree-right-side-view](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0199-binary-tree-right-side-view/) | Medium |
| [0226-invert-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0226-invert-binary-tree/) | Easy |
| [0236-lowest-common-ancestor-of-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0236-lowest-common-ancestor-of-a-binary-tree/) | Medium |
| [0257-binary-tree-paths](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0257-binary-tree-paths/) | Easy |
| [0404-sum-of-left-leaves](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0404-sum-of-left-leaves/) | Easy |
| [0450-delete-node-in-a-bst](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0450-delete-node-in-a-bst/) | Medium |
| [0700-search-in-a-binary-search-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0700-search-in-a-binary-search-tree/) | Easy |
| [1161-maximum-level-sum-of-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1161-maximum-level-sum-of-a-binary-tree/) | Medium |
| [1372-longest-zigzag-path-in-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1372-longest-zigzag-path-in-a-binary-tree/) | Medium |
## Math
| Problem Name | Difficulty |
| ------- | ------- |
| [0231-power-of-two](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0231-power-of-two/) | Easy |
| [0258-add-digits](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0258-add-digits/) | Easy |
| [0263-ugly-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0263-ugly-number/) | Easy |
| [0268-missing-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0268-missing-number/) | Easy |
| [0292-nim-game](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0292-nim-game/) | Easy |
| [0326-power-of-three](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0326-power-of-three/) | Easy |
| [0342-power-of-four](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0342-power-of-four/) | Easy |
| [0367-valid-perfect-square](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0367-valid-perfect-square/) | Easy |
| [0412-fizz-buzz](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0412-fizz-buzz/) | Easy |
| [0415-add-strings](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0415-add-strings/) | Easy |
| [0441-arranging-coins](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0441-arranging-coins/) | Easy |
| [0509-fibonacci-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0509-fibonacci-number/) | Easy |
| [1025-divisor-game](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/1025-divisor-game/) | Easy |
| [1137-n-th-tribonacci-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/1137-n-th-tribonacci-number/) | Easy |
## Bit Manipulation
| Problem Name | Difficulty |
| ------- | ------- |
| [0231-power-of-two](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0231-power-of-two/) | Easy |
| [0268-missing-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0268-missing-number/) | Easy |
| [0338-counting-bits](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0338-counting-bits/) | Easy |
| [0342-power-of-four](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0342-power-of-four/) | Easy |
| [0389-find-the-difference](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0389-find-the-difference/) | Easy |
| [0401-binary-watch](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0401-binary-watch/) | Easy |
## Recursion
| Problem Name | Difficulty |
| ------- | ------- |
| [0231-power-of-two](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0231-power-of-two/) | Easy |
| [0234-palindrome-linked-list](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0234-palindrome-linked-list/) | Easy |
| [0326-power-of-three](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0326-power-of-three/) | Easy |
| [0342-power-of-four](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0342-power-of-four/) | Easy |
| [0394-decode-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0394-decode-string/) | Medium |
| [0509-fibonacci-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0509-fibonacci-number/) | Easy |
## Stack
| Problem Name | Difficulty |
| ------- | ------- |
| [0232-implement-queue-using-stacks](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0232-implement-queue-using-stacks/) | Easy |
| [0234-palindrome-linked-list](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0234-palindrome-linked-list/) | Easy |
| [0394-decode-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0394-decode-string/) | Medium |
## Design
| Problem Name | Difficulty |
| ------- | ------- |
| [0208-implement-trie-prefix-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0208-implement-trie-prefix-tree/) | Medium |
| [0232-implement-queue-using-stacks](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0232-implement-queue-using-stacks/) | Easy |
| [0303-range-sum-query-immutable](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0303-range-sum-query-immutable/) | Easy |
| [2336-smallest-number-in-infinite-set](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2336-smallest-number-in-infinite-set/) | Medium |
## Queue
| Problem Name | Difficulty |
| ------- | ------- |
| [0232-implement-queue-using-stacks](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0232-implement-queue-using-stacks/) | Easy |
| [0387-first-unique-character-in-a-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0387-first-unique-character-in-a-string/) | Easy |
## Linked List
| Problem Name | Difficulty |
| ------- | ------- |
| [0234-palindrome-linked-list](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0234-palindrome-linked-list/) | Easy |
| [0328-odd-even-linked-list](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0328-odd-even-linked-list/) | Medium |
## Two Pointers
| Problem Name | Difficulty |
| ------- | ------- |
| [0234-palindrome-linked-list](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0234-palindrome-linked-list/) | Easy |
| [0283-move-zeroes](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0283-move-zeroes/) | Easy |
| [0344-reverse-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0344-reverse-string/) | Easy |
| [0345-reverse-vowels-of-a-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0345-reverse-vowels-of-a-string/) | Easy |
| [0349-intersection-of-two-arrays](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0349-intersection-of-two-arrays/) | Easy |
| [0350-intersection-of-two-arrays-ii](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0350-intersection-of-two-arrays-ii/) | Easy |
| [0392-is-subsequence](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0392-is-subsequence/) | Easy |
| [0443-string-compression](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0443-string-compression/) | Medium |
| [2300-successful-pairs-of-spells-and-potions](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2300-successful-pairs-of-spells-and-potions/) | Medium |
| [2462-total-cost-to-hire-k-workers](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2462-total-cost-to-hire-k-workers/) | Medium |
## Array
| Problem Name | Difficulty |
| ------- | ------- |
| [0162-find-peak-element](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0162-find-peak-element/) | Medium |
| [0198-house-robber](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0198-house-robber/) | Medium |
| [0215-kth-largest-element-in-an-array](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0215-kth-largest-element-in-an-array/) | Medium |
| [0216-combination-sum-iii](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0216-combination-sum-iii/) | Medium |
| [0238-product-of-array-except-self](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0238-product-of-array-except-self/) | Medium |
| [0268-missing-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0268-missing-number/) | Easy |
| [0283-move-zeroes](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0283-move-zeroes/) | Easy |
| [0303-range-sum-query-immutable](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0303-range-sum-query-immutable/) | Easy |
| [0334-increasing-triplet-subsequence](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0334-increasing-triplet-subsequence/) | Medium |
| [0349-intersection-of-two-arrays](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0349-intersection-of-two-arrays/) | Easy |
| [0350-intersection-of-two-arrays-ii](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0350-intersection-of-two-arrays-ii/) | Easy |
| [0399-evaluate-division](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0399-evaluate-division/) | Medium |
| [0414-third-maximum-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0414-third-maximum-number/) | Easy |
| [0746-min-cost-climbing-stairs](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0746-min-cost-climbing-stairs/) | Easy |
| [0875-koko-eating-bananas](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0875-koko-eating-bananas/) | Medium |
| [0994-rotting-oranges](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0994-rotting-oranges/) | Medium |
| [1926-nearest-exit-from-entrance-in-maze](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1926-nearest-exit-from-entrance-in-maze/) | Medium |
| [2300-successful-pairs-of-spells-and-potions](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2300-successful-pairs-of-spells-and-potions/) | Medium |
| [2462-total-cost-to-hire-k-workers](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2462-total-cost-to-hire-k-workers/) | Medium |
| [2542-maximum-subsequence-score](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2542-maximum-subsequence-score/) | Medium |
## Prefix Sum
| Problem Name | Difficulty |
| ------- | ------- |
| [0238-product-of-array-except-self](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0238-product-of-array-except-self/) | Medium |
| [0303-range-sum-query-immutable](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0303-range-sum-query-immutable/) | Easy |
## Hash Table
| Problem Name | Difficulty |
| ------- | ------- |
| [0017-letter-combinations-of-a-phone-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0017-letter-combinations-of-a-phone-number/) | Medium |
| [0208-implement-trie-prefix-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0208-implement-trie-prefix-tree/) | Medium |
| [0242-valid-anagram](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0242-valid-anagram/) | Easy |
| [0268-missing-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0268-missing-number/) | Easy |
| [0290-word-pattern](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0290-word-pattern/) | Easy |
| [0349-intersection-of-two-arrays](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0349-intersection-of-two-arrays/) | Easy |
| [0350-intersection-of-two-arrays-ii](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0350-intersection-of-two-arrays-ii/) | Easy |
| [0383-ransom-note](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0383-ransom-note/) | Easy |
| [0387-first-unique-character-in-a-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0387-first-unique-character-in-a-string/) | Easy |
| [0389-find-the-difference](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0389-find-the-difference/) | Easy |
| [0409-longest-palindrome](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0409-longest-palindrome/) | Easy |
| [2336-smallest-number-in-infinite-set](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2336-smallest-number-in-infinite-set/) | Medium |
## String
| Problem Name | Difficulty |
| ------- | ------- |
| [0017-letter-combinations-of-a-phone-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0017-letter-combinations-of-a-phone-number/) | Medium |
| [0208-implement-trie-prefix-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0208-implement-trie-prefix-tree/) | Medium |
| [0242-valid-anagram](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0242-valid-anagram/) | Easy |
| [0257-binary-tree-paths](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0257-binary-tree-paths/) | Easy |
| [0290-word-pattern](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0290-word-pattern/) | Easy |
| [0344-reverse-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0344-reverse-string/) | Easy |
| [0345-reverse-vowels-of-a-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0345-reverse-vowels-of-a-string/) | Easy |
| [0383-ransom-note](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0383-ransom-note/) | Easy |
| [0387-first-unique-character-in-a-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0387-first-unique-character-in-a-string/) | Easy |
| [0389-find-the-difference](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0389-find-the-difference/) | Easy |
| [0392-is-subsequence](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0392-is-subsequence/) | Easy |
| [0394-decode-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0394-decode-string/) | Medium |
| [0399-evaluate-division](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0399-evaluate-division/) | Medium |
| [0409-longest-palindrome](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0409-longest-palindrome/) | Easy |
| [0412-fizz-buzz](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0412-fizz-buzz/) | Easy |
| [0415-add-strings](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0415-add-strings/) | Easy |
| [0434-number-of-segments-in-a-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0434-number-of-segments-in-a-string/) | Easy |
| [0443-string-compression](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0443-string-compression/) | Medium |
## Sorting
| Problem Name | Difficulty |
| ------- | ------- |
| [0215-kth-largest-element-in-an-array](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0215-kth-largest-element-in-an-array/) | Medium |
| [0242-valid-anagram](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0242-valid-anagram/) | Easy |
| [0268-missing-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0268-missing-number/) | Easy |
| [0349-intersection-of-two-arrays](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0349-intersection-of-two-arrays/) | Easy |
| [0350-intersection-of-two-arrays-ii](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0350-intersection-of-two-arrays-ii/) | Easy |
| [0389-find-the-difference](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0389-find-the-difference/) | Easy |
| [0414-third-maximum-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0414-third-maximum-number/) | Easy |
| [2300-successful-pairs-of-spells-and-potions](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2300-successful-pairs-of-spells-and-potions/) | Medium |
| [2542-maximum-subsequence-score](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2542-maximum-subsequence-score/) | Medium |
## Backtracking
| Problem Name | Difficulty |
| ------- | ------- |
| [0017-letter-combinations-of-a-phone-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0017-letter-combinations-of-a-phone-number/) | Medium |
| [0216-combination-sum-iii](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0216-combination-sum-iii/) | Medium |
| [0257-binary-tree-paths](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0257-binary-tree-paths/) | Easy |
| [0401-binary-watch](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0401-binary-watch/) | Easy |
## Simulation
| Problem Name | Difficulty |
| ------- | ------- |
| [0258-add-digits](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0258-add-digits/) | Easy |
| [0412-fizz-buzz](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0412-fizz-buzz/) | Easy |
| [0415-add-strings](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0415-add-strings/) | Easy |
| [2462-total-cost-to-hire-k-workers](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2462-total-cost-to-hire-k-workers/) | Medium |
## Number Theory
| Problem Name | Difficulty |
| ------- | ------- |
| [0258-add-digits](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0258-add-digits/) | Easy |
## Binary Search
| Problem Name | Difficulty |
| ------- | ------- |
| [0162-find-peak-element](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0162-find-peak-element/) | Medium |
| [0268-missing-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0268-missing-number/) | Easy |
| [0278-first-bad-version](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0278-first-bad-version/) | Easy |
| [0349-intersection-of-two-arrays](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0349-intersection-of-two-arrays/) | Easy |
| [0350-intersection-of-two-arrays-ii](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0350-intersection-of-two-arrays-ii/) | Easy |
| [0367-valid-perfect-square](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0367-valid-perfect-square/) | Easy |
| [0374-guess-number-higher-or-lower](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0374-guess-number-higher-or-lower/) | Easy |
| [0441-arranging-coins](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0441-arranging-coins/) | Easy |
| [0875-koko-eating-bananas](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0875-koko-eating-bananas/) | Medium |
| [2300-successful-pairs-of-spells-and-potions](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2300-successful-pairs-of-spells-and-potions/) | Medium |
## Interactive
| Problem Name | Difficulty |
| ------- | ------- |
| [0278-first-bad-version](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0278-first-bad-version/) | Easy |
| [0374-guess-number-higher-or-lower](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0374-guess-number-higher-or-lower/) | Easy |
## Brainteaser
| Problem Name | Difficulty |
| ------- | ------- |
| [0292-nim-game](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0292-nim-game/) | Easy |
| [1025-divisor-game](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/1025-divisor-game/) | Easy |
## Game Theory
| Problem Name | Difficulty |
| ------- | ------- |
| [0292-nim-game](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0292-nim-game/) | Easy |
| [1025-divisor-game](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/1025-divisor-game/) | Easy |
## Greedy
| Problem Name | Difficulty |
| ------- | ------- |
| [0334-increasing-triplet-subsequence](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0334-increasing-triplet-subsequence/) | Medium |
| [0409-longest-palindrome](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0409-longest-palindrome/) | Easy |
| [2542-maximum-subsequence-score](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2542-maximum-subsequence-score/) | Medium |
## Dynamic Programming
| Problem Name | Difficulty |
| ------- | ------- |
| [0198-house-robber](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0198-house-robber/) | Medium |
| [0338-counting-bits](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0338-counting-bits/) | Easy |
| [0392-is-subsequence](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0392-is-subsequence/) | Easy |
| [0509-fibonacci-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0509-fibonacci-number/) | Easy |
| [0746-min-cost-climbing-stairs](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0746-min-cost-climbing-stairs/) | Easy |
| [0790-domino-and-tromino-tiling](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0790-domino-and-tromino-tiling/) | Medium |
| [1025-divisor-game](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/1025-divisor-game/) | Easy |
| [1137-n-th-tribonacci-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/1137-n-th-tribonacci-number/) | Easy |
| [1372-longest-zigzag-path-in-a-binary-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1372-longest-zigzag-path-in-a-binary-tree/) | Medium |
## Counting
| Problem Name | Difficulty |
| ------- | ------- |
| [0383-ransom-note](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0383-ransom-note/) | Easy |
| [0387-first-unique-character-in-a-string](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0387-first-unique-character-in-a-string/) | Easy |
## Binary Search Tree
| Problem Name | Difficulty |
| ------- | ------- |
| [0450-delete-node-in-a-bst](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0450-delete-node-in-a-bst/) | Medium |
| [0700-search-in-a-binary-search-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0700-search-in-a-binary-search-tree/) | Easy |
## Graph Theory
| Problem Name | Difficulty |
| ------- | ------- |
| [0399-evaluate-division](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0399-evaluate-division/) | Medium |
| [0547-number-of-provinces](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0547-number-of-provinces/) | Medium |
| [0841-keys-and-rooms](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0841-keys-and-rooms/) | Medium |
| [1466-reorder-routes-to-make-all-paths-lead-to-the-city-zero](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1466-reorder-routes-to-make-all-paths-lead-to-the-city-zero/) | Medium |
## Union-Find
| Problem Name | Difficulty |
| ------- | ------- |
| [0399-evaluate-division](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0399-evaluate-division/) | Medium |
| [0547-number-of-provinces](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0547-number-of-provinces/) | Medium |
## Shortest Path
| Problem Name | Difficulty |
| ------- | ------- |
| [0399-evaluate-division](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0399-evaluate-division/) | Medium |
## Matrix
| Problem Name | Difficulty |
| ------- | ------- |
| [0994-rotting-oranges](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0994-rotting-oranges/) | Medium |
| [1926-nearest-exit-from-entrance-in-maze](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/1926-nearest-exit-from-entrance-in-maze/) | Medium |
## Divide and Conquer
| Problem Name | Difficulty |
| ------- | ------- |
| [0215-kth-largest-element-in-an-array](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0215-kth-largest-element-in-an-array/) | Medium |
## Heap (Priority Queue)
| Problem Name | Difficulty |
| ------- | ------- |
| [0215-kth-largest-element-in-an-array](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0215-kth-largest-element-in-an-array/) | Medium |
| [2336-smallest-number-in-infinite-set](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2336-smallest-number-in-infinite-set/) | Medium |
| [2462-total-cost-to-hire-k-workers](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2462-total-cost-to-hire-k-workers/) | Medium |
| [2542-maximum-subsequence-score](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2542-maximum-subsequence-score/) | Medium |
## Quickselect
| Problem Name | Difficulty |
| ------- | ------- |
| [0215-kth-largest-element-in-an-array](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0215-kth-largest-element-in-an-array/) | Medium |
## Ordered Set
| Problem Name | Difficulty |
| ------- | ------- |
| [2336-smallest-number-in-infinite-set](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/2336-smallest-number-in-infinite-set/) | Medium |
## Trie
| Problem Name | Difficulty |
| ------- | ------- |
| [0208-implement-trie-prefix-tree](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Medium/0208-implement-trie-prefix-tree/) | Medium |
## Memoization
| Problem Name | Difficulty |
| ------- | ------- |
| [0509-fibonacci-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/0509-fibonacci-number/) | Easy |
| [1137-n-th-tribonacci-number](https://github.com/sokeks/LeetCode-Solutions/tree/main/LeetCode/Easy/1137-n-th-tribonacci-number/) | Easy |
<!---LeetCode Topics End-->

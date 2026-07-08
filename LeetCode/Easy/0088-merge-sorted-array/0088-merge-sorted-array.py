class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        n1_i = m - 1
        n2_i = n - 1
        r_i = m + n - 1

        while n1_i >= 0 and n2_i >= 0:
            if nums1[n1_i] > nums2[n2_i]:
                nums1[r_i] = nums1[n1_i]
                n1_i -= 1
            else:
                nums1[r_i] = nums2[n2_i]
                n2_i -= 1
            r_i -= 1

        if n2_i >= 0:
            stop_idx = n2_i + 1
            nums1[:stop_idx] = nums2[:stop_idx]
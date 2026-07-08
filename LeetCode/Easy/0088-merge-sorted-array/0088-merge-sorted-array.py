class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        n1_i = m - len(nums1) - 1
        n2_i = n - len(nums2) - 1
        r_i = -1

        while n1_i >= -len(nums1) and n2_i >= -len(nums2):
            if nums1[n1_i] > nums2[n2_i]:
                nums1[r_i] = nums1[n1_i]
                n1_i -= 1
            else:
                nums1[r_i] = nums2[n2_i]
                n2_i -= 1
            r_i -= 1

        if n2_i >= -len(nums2):
            stop_idx = len(nums2) + 1 + n2_i
            nums1[:stop_idx] = nums2[:stop_idx]
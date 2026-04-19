class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        for n, i in enumerate(nums):
            for m, j in enumerate(nums):
                if i == j and m > n:
                    return True
        return False
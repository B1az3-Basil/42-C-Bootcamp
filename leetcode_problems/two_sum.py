class Solution:
    def twosum(self, nums, target):
        if len(nums) == 0:
            return nums
        sum_two = nums[0] + nums[-1]
        i = 0
        i_back = len(nums) - 1
        while sum_two != target:
            sum_two = nums[i] + nums[i_back]
            if i_back == -1:
                return []

            if sum_two == target:
                break

            if i == len(nums) - 1:
                i = 0
                i_back -= 1
                continue


            i += 1

        return [nums.index(nums[i]), nums.index(nums[i_back])]


if __name__ == "__main__":
    ins = Solution()
    print(ins.twosum([3,2,4], 9))

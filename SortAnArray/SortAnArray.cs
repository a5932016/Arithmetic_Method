public class SortAnArray {
    public int[] SortArray(int[] nums) 
    {
        if (nums.Length <= 1)
            return nums;
        int count = nums.Length / 2;
        int[] left = SortArray(copy(nums, 0, count));
        int[] right = SortArray(copy(nums, count, nums.Length - count));

        return merge(left,right);
    }
    
    public int[] merge(int[] left, int[] right)
    {
        int[] ret = new int[left.Length + right.Length];
        int LeftCount = 0, rightCount = 0, retCount = 0;
        while (LeftCount < left.Length && rightCount < right.Length)
        {
            if (left[LeftCount] < right[rightCount])
                ret[retCount++] = left[LeftCount++];
            else
                ret[retCount++] = right[rightCount++];
        }

        while (LeftCount < left.Length)
            ret[retCount++] = left[LeftCount++];
        while (rightCount < right.Length)
            ret[retCount++] = right[rightCount++];

        return ret;
    }
    
    public int[] copy(int[] nums,int start,int count)
    {
        int[] ans = new int[count];
        for(int i =0;i<count;i++)
        {
            ans[i]=nums[start++];
        }
        return ans;
    }
}
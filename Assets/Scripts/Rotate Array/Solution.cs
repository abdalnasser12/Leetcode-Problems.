public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; 
        if (k == 0) return;
        
        
        Reverse(nums, 0, n - 1); 
        Reverse(nums, 0, k - 1); 
        Reverse(nums, k, n - 1); 
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
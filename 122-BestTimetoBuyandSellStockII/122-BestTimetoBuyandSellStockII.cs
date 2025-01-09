public class Solution {
    public bool CanJump(int[] nums) {
        
        //greed

        if(nums.Length == 1){
            return true;
        }

        int distance = 0;

        for(int i=0; i < nums.Length - 1; i++){
           
            if(i > distance){
                return false;
            }

            distance = Math.Max(distance, i + nums[i]);

            if (distance >= nums.Length - 1) {
                return true;
        }
    }

     return false;
    }
}
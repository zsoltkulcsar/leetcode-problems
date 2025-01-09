public class Solution {
    public int MajorityElement(int[] nums) {
        //Boyer-Moore Voting Algorithm

        int count = 0;
        int candidate = 0;

        foreach (int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }

     return candidate;
    }
}
public class Solution {
    public int HIndex(int[] citations) {

        Array.Sort(citations);
        Array.Reverse(citations);

        int hIndex = 0;

        for (int i = 0; i < citations.Length; i++) {
            if (citations[i] >= i + 1) {
                hIndex = i + 1;
            } else {
                break;
            }
        }

        return hIndex;
    }
}
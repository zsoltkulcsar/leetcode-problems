public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            map[key].Add(str);
        }

        return map.Values.Select(group => (IList<string>)group).ToList();
    }
}
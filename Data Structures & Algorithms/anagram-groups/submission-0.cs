public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            map[key].Add(word);
        }

        return new List<List<string>>(map.Values);
    }
}

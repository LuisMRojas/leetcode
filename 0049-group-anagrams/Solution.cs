public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();
        foreach (string word in strs) {
            string key = SortWord(word);
            if (!groups.TryGetValue(key, out List<string> list)) {
                list = new List<string>();
                groups[key] = list;
            }
            list.Add(word);
        }
        return new List<IList<string>>(groups.Values);
    }

    public string SortWord(string e){
        char[] word = e.ToCharArray();
        Array.Sort(word);
        return new string(word);
    }
}

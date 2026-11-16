public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // if(strs.Length==0) return strs;
        // var keys = new HashSet<string>();

        // for(int i=0; i<strs.Lenght; i++){
        //     keys.Add(SortWord(strs[i]));
        // }

        // Dictionary<string, List<string>> dictionaryAnagram = keys.ToDictionary(k => k, k => (string?)null);

        // foreach(string element in strs){
        //     if(dictionaryAnagram.TryGetValue(SortWord(element),  out List<string>? anagrams)){
        //         anagrams.add(element);
        //     }
        // }

        // var result;
        // foreach(string element in dictionaryAnagram){
        //     result.Add(element.Value);
        // }
        // return result;
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

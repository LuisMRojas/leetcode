public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0) return new List<IList<string>>();
        var keys = new HashSet<string>();

        for (int i = 0; i < strs.Length; i++) {
            keys.Add(SortWord(strs[i]));
        }

        Dictionary<string, List<string>> dictionaryAnagram = keys.ToDictionary(k => k, k => new List<string>());

        foreach(string element in strs){
            if(dictionaryAnagram.TryGetValue(SortWord(element),  out List<string>? anagrams)){
                anagrams.Add(element);
            }
        }

        var result = new List<IList<string>>();
        foreach (var element in dictionaryAnagram) {
            result.Add(element.Value);
        }
        return result;
    }

    public string SortWord(string e){
        char[] word = e.ToCharArray();
        Array.Sort(word);
        return new string(word);
    }
}

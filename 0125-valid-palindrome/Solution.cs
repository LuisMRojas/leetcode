public class Solution {
    public bool IsPalindrome(string s) {
        s = s.Replace(" ", "");
        s = new string(s.Where(char.IsLetterOrDigit).ToArray());
        s = s.ToLower();
        char[] t = s.ToCharArray();
        Array.Reverse(t);
        string tString = new string(t);

        Console.WriteLine($"s: {s}; t={tString}; s.Length= {s.Length}");
        if(s.Length>0){
            if (s == tString){

                Console.WriteLine($"s: {s}; t={tString}");

                return true;
            }
            return false;
        }
        return true;
    }
}

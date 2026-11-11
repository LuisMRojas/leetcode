public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var seen = new HashSet<int>();      // la libreta, empieza vacía
        foreach (int n in nums)             // toma cada número, uno por uno
            // intenta anotarlo; si ya estaba, hay duplicado, no se puede anotar el mismo numero en el mismo hash, si ya existe devuelve true, si no continua
            if (!seen.Add(n)) return true;  
        return false;                       // terminaste y nunca se repitió ninguno
    }
}

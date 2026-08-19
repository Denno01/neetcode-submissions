public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> hs = new Dictionary<char,int>();
        Dictionary<char,int> hs2 = new Dictionary<char,int>();

    foreach (char c in s)
    {
        if (hs.ContainsKey(c))
            hs[c]++;
        else
            hs.Add(c, 1);
    }
        foreach (char c in t)
        {
            if (hs2.ContainsKey(c))
                hs2[c]++;
            else
                hs2.Add(c,1);    
        }
        if(hs.Count != hs2.Count)
        {
            return false;
        }

        foreach(KeyValuePair<char, int> pair in hs)
        {
            char character = pair.Key;
            int occurrences = pair.Value;

            if(!hs2.ContainsKey(character))
            {
                return false;
            }
            if(hs2[character]!= occurrences)
            {
                return false;
            }

        }

        return true;
    }
}

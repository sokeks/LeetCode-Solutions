public class Solution {
    public string RemoveStars(string s) {
        var buffer = new char[s.Length];
        var write = 0;

        foreach (var c in s)
        {
            if (c != '*')
            {
                buffer[write++] = c;
            }
            else
            {
                write--;
            }
        }

        return new string(buffer.AsSpan(0, write));   
    }
}

// **** worse (more complex/overengineered) solution below ****

// public class Solution {
//     public string RemoveStars(string s) {
//         var buffer = new char[s.Length];
//         var write = buffer.Length - 1;
        
//         var starDebt = 0;
//         var read = buffer.Length - 1;
//         while (read >= 0)
//         {
//             if (s[read] == '*')
//             {
//                 starDebt++;
//             }
//             else if (starDebt > 0)
//             {
//                 starDebt--;
//             }
//             else
//             {
//                 buffer[write--] = s[read];
//             }
//             read--;
//         }

//         return new string(buffer.AsSpan(write + 1, s.Length - (write + 1)));
        
//     }
// }


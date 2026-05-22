public class Solution {
    public IList<string> FizzBuzz(int n) {
        var answers = new string[n];

        for (var i = 0; i < n; i++)
        {
            if ((i + 1) % 15 == 0)
            {
                answers[i] = "FizzBuzz";
            }
            else if ((i + 1) % 5 == 0)
            {
                answers[i] = "Buzz";
            }
            else if ((i + 1) % 3 == 0)
            {
                answers[i] = "Fizz";
            }
            else
            {
                answers[i] = (i + 1).ToString();
            }          
        }
        return answers;
    }
}
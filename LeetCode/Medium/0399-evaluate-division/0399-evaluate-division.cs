public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var adjacency = new Dictionary<string, List<(string neighbour, double weight)>>();
        for (var i = 0; i < equations.Count; i++) AddEquationToAdjacency(equations[i], values[i], adjacency);

        var answers = new double[queries.Count];
        foreach (ref double answer in answers.AsSpan()) answer = -1;
        for (var i = 0; i < queries.Count; i++)
        {
            var query = queries[i];
            if (!adjacency.ContainsKey(query[0]) || !adjacency.ContainsKey(query[1])) continue;

            var visitedVariables = new HashSet<string>();
            var nextVariables = new Stack<(string variable, double result)>();
            nextVariables.Push((query[0], 1.0));
            while (nextVariables.Count > 0)
            {
                var (variable, currentResult) = nextVariables.Pop();

                foreach (var (neighbour, weight) in adjacency[variable])
                {
                    if (visitedVariables.Contains(neighbour)) continue;

                    var result = currentResult * weight;
                    if (neighbour == query[1])
                    {
                        answers[i] = result;
                        break;
                    }
                    visitedVariables.Add(neighbour);
                    nextVariables.Push((neighbour, result));
                }
            }
        }

        return answers;
        static void AddEquationToAdjacency(IList<string> equation, double value, Dictionary<string, List<(string neighbour, double weight)>> adjacency)
        {
            AddToAdjacency(equation[0], equation[1], value, adjacency);
            AddToAdjacency(equation[1], equation[0], 1.0 / value, adjacency);
        }

        static void AddToAdjacency(string start, string end, double weight, Dictionary<string, List<(string neighbour, double weight)>> adjacency)
        {
            if (adjacency.TryGetValue(start, out List<(string neighbour, double weight)> list))
            {
                list.Add((end, weight));
            }
            else
            {
                adjacency[start] = new List<(string, double)> { (end, weight) };
            }
        }
    }
}
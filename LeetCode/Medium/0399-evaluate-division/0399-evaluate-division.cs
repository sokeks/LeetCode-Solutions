public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var adjacency = new Dictionary<string, List<(string neighbour, double weight)>>();
        for (var i = 0; i < equations.Count; i++) AddEquationToAdjacency(equations[i], values[i], adjacency);

        var answers = new double[queries.Count];
        for (var i = 0; i < queries.Count; i++)
        {
            var query = queries[i];

            answers[i] = !adjacency.ContainsKey(query[0]) || !adjacency.ContainsKey(query[1])
                ? -1
                : CalculateAnswerToQuery(adjacency, query);
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

    private double CalculateAnswerToQuery(Dictionary<string, List<(string neighbour, double weight)>> adjacency, IList<string> query)
    {
        if (query[0] == query[1]) return 1;

        var nextVariables = new Stack<(string variable, double result)>();
        nextVariables.Push((query[0], 1.0));
        var visitedVariables = new HashSet<string>();
        visitedVariables.Add(query[0]);
        while (nextVariables.Count > 0)
        {
            var (variable, currentResult) = nextVariables.Pop();

            foreach (var (neighbour, weight) in adjacency[variable])
            {
                if (visitedVariables.Contains(neighbour)) continue;

                var result = currentResult * weight;
                if (neighbour == query[1])
                {
                    return result;
                }
                nextVariables.Push((neighbour, result));
                visitedVariables.Add(neighbour);
            }
        }

        return -1;
    }
}
public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var defaultCapacity = 32;
        var nums = new Stack<int>(defaultCapacity);
        nums.Push(0);
        var visitedRooms = new HashSet<int>();

        while (nums.Count > 0 && visitedRooms.Count != rooms.Count)
        {
            var num = nums.Pop();
            visitedRooms.Add(num);
            for (var i = 0; i < rooms[num].Count; i++)
            {
                if (!visitedRooms.Contains(rooms[num][i])) nums.Push(rooms[num][i]);
            }
        }

        return rooms.Count == visitedRooms.Count;
    }
}
public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var keysToTry = new Stack<int>(rooms.Count);
        keysToTry.Push(0);
        Span<bool> visitedRooms = rooms.Count <= 1024 ? stackalloc bool[rooms.Count] : new bool[rooms.Count];
        var visitedRoomsCount = 0;

        while (keysToTry.Count > 0 && visitedRoomsCount != rooms.Count)
        {
            var key = keysToTry.Pop();
            if (!visitedRooms[key])
            {
                visitedRooms[key] = true;
                visitedRoomsCount++;
            }
            for (var i = 0; i < rooms[key].Count; i++)
            {
                if (!visitedRooms[rooms[key][i]]) keysToTry.Push(rooms[key][i]);
            }
        }

        return rooms.Count == visitedRoomsCount;
    }
}
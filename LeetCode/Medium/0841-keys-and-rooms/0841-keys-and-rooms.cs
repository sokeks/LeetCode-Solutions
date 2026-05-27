public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var keysToTry = new Stack<int>(rooms.Count);
        Span<bool> visitedRooms = rooms.Count <= 1024 ? stackalloc bool[rooms.Count] : new bool[rooms.Count];

        keysToTry.Push(0);
        visitedRooms[0] = true;
        var visitedRoomsCount = 1;

        while (keysToTry.Count > 0 && visitedRoomsCount != rooms.Count)
        {
            var key = keysToTry.Pop();
            for (var i = 0; i < rooms[key].Count; i++)
            {
                var nextRoom = rooms[key][i];
                if (!visitedRooms[nextRoom])
                {
                    visitedRooms[nextRoom] = true;
                    visitedRoomsCount++;
                    keysToTry.Push(nextRoom);
                }
            }
        }

        return rooms.Count == visitedRoomsCount;
    }
}
class Solution:
    def smallestEquivalentString(self, s1: str, s2: str, baseStr: str) -> str:
        parent: dict[str, str] = {x : x for x in string.ascii_lowercase}

        def find(c: str) -> str:
            if c != parent[c]:
                parent[c] = find(parent[c])
            return parent[c]

        def union(x: str, y: str) -> None:
            root_x = find(x)
            root_y = find(y)


            if root_x < root_y:
                parent[root_y] = root_x
            else:
                parent[root_x] = root_y

        for x, y in zip(s1, s2):
            union(x, y)

        return "".join(find(c) for c in baseStr)
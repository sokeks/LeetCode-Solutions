class Solution:
    def smallestEquivalentString(self, s1: str, s2: str, baseStr: str) -> str:
        targets: dict[str, str] = {x : x for x in string.ascii_lowercase}
        # print(", ".join(f"{k}->{v}" for k,v in targets.items()))

        def find(c: str) -> str:
            if c != targets[c]:
                targets[c] = find(targets[c])
            return targets[c]

        def union(x: str, y: str):
            target_x = find(x)
            target_y = find(y)

            # print(f"{target_x} {target_y}")

            if target_x < target_y:
                targets[target_y] = target_x
            else:
                targets[target_x] = target_y

        for x, y in zip(s1, s2):
            union(x, y)
        # print(", ".join(f"{k}->{v}" for k,v in targets.items()))


        base = list(baseStr)
        for i in range(len(base)):
            base[i] = find(base[i])
        return "".join(base)
class Solution {
    std::array<char, 26> parent;

    int getIndex(char c) const {
        return c - 'a';
    }

public:
    Solution()
    {
        for (auto i = 0; i < 26; ++i) {
            parent[i] = 'a' + i;
        }
    }

    char find(char c)
    {
        auto idx = getIndex(c);
        if (parent[idx] == c)
        {
            return c;
        }

        return parent[idx] = find(parent[idx]);
    }

    void unite(char c1, char c2)
    {
        auto root1 = find(c1);
        auto root2 = find(c2);

        if (root1 < root2)
        {
            parent[getIndex(root2)] = root1;
        }
        else
        {
            parent[getIndex(root1)] = root2;
        }
    }

    string smallestEquivalentString(string s1, string s2, string baseStr) {
        for (auto [c1, c2] : std::views::zip(s1, s2)) {
            unite(c1, c2);
        }

        return baseStr
                | std::views::transform([this](char c) { return find(c); })
                | std::ranges::to<std::string>();
    }
};
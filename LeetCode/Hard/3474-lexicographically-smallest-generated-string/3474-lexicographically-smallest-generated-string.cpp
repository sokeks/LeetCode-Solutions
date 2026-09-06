class Solution {
public:
    string generateString(string str1, string str2) {
        string result(str1.size() + str2.size() - 1, 'a');
        vector<bool> fixed(str1.size() + str2.size() - 1);

        for (auto [i, condition] : views::enumerate(str1))
        {
            if (condition == 'F') continue;

            for (auto j = 0; j < str2.size(); ++j)
            {
                auto w = i + j;
                auto c_pattern = str2[j];

                if (fixed[w] && result[w] != c_pattern) return "";

                result[w] = c_pattern;
                fixed[w] = true;
            }
        }

        string_view pattern = str2;
        for (auto [i, condition] : views::enumerate(str1))
        {
            if (condition == 'T' || string_view(result.data() + i, str2.size()) != pattern) continue;

            auto j = str2.size();
            bool wasChanged = false;
            for (; j-- > 0;)
            {
                auto w = i + j;
                cout << w << endl;
                if (fixed[w]) continue;

                result[w] = 'b';
                fixed[w] = wasChanged = true;
                break;
            }

            if (!wasChanged) return "";
        }

        return result; 
    }
};
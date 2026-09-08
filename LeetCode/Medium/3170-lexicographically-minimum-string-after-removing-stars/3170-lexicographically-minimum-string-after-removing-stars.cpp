class Solution {
public:
    string clearStars(string s) {
        priority_queue<char, vector<char>, greater<char>> available_chars_heap;
        unordered_map<char, stack<size_t>> char_positions;

        string result = s;
        for (auto [i, c] : views::enumerate(result))
        {
            if (c != '*')
            {
                if (char_positions[c].size() == 0)
                {
                    available_chars_heap.push(c);
                }
                char_positions[c].push(i);
            }
            else
            {
                auto available_char = available_chars_heap.top();
                result[char_positions[available_char].top()] = '*';
                char_positions[available_char].pop();

                if (char_positions[available_char].size() == 0) available_chars_heap.pop();
            }
        }

        erase(result, '*');
        return result;    
    }

};
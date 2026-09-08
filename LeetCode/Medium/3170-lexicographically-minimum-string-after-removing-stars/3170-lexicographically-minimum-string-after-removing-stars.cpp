class Solution {
public:
    string clearStars(string s) {
        priority_queue<char, vector<char>, greater<char>> smallest_available_chars_heap;
        stack<size_t> char_positions[26];

        string result = s;
        for (auto [i, c] : views::enumerate(result))
        {
            if (c != '*')
            {
                if (char_positions[c - 'a'].size() == 0)
                {
                    smallest_available_chars_heap.push(c);
                }
                char_positions[c - 'a'].push(i);
            }
            else
            {
                auto smallest_char = smallest_available_chars_heap.top();
                result[char_positions[smallest_char - 'a'].top()] = '*';
                char_positions[smallest_char - 'a'].pop();

                if (char_positions[smallest_char - 'a'].empty()) smallest_available_chars_heap.pop();
            }
        }

        erase(result, '*');
        return result;    
    }

};
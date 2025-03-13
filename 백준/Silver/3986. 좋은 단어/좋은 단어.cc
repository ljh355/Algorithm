#include <iostream>
#include <stack>

using namespace std;

int main() {
    int n;

    cin >> n;

    int result = 0;

    for (int i = 0; i < n; i++) {
        stack<char> st;
        string word;
        cin >> word;

        for (int j = 0; j < word.length(); j++) {
            if (st.empty()) {
                st.push(word[j]);
            } else {
                if (st.top() == word[j]) {
                    st.pop();
                } else {
                    st.push(word[j]);
                }
            }
        }

        if(st.empty()) {
            result++;
        }
    }

    cout << result;
    
    return 0;
}
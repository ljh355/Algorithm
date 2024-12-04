#include <bits/stdc++.h>
using namespace std;

int main() {
    // 백준 1159

    int n;
    cin >> n;

    map<string, int> map;
    string answer;

    for (int i = 0; i < n; i++) {
        string temp;
        cin >> temp;
        map[temp.substr(0, 1)]++;   
    }

    for (const auto& pair : map) {
        if (pair.second >= 5) {
            answer += pair.first;
        }
    }

    if (answer.empty()) {
        answer = "PREDAJA";
    }

    cout << answer;
    
    return 0;
}